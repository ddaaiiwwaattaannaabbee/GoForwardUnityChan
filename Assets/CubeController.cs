using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

        // キューブの移動速度
        private float speed = -0.2f;

        // 消滅位置
        private float deadLine = -10;
        
        // Use this for initialization
        void Start(){
        }

        // Update is called once per frame
        void Update () {
                // キューブを移動させる
                transform.Translate (this.speed, 0, 0);
                
                // 画面外に出たら破棄する
                if (transform.position.x < this.deadLine){
                        Destroy (gameObject);
                }
        }

        //衝突時に呼ばれる関数
        void OnCollisionEnter2D(Collision2D other) {
                //衝突したオブジェクトによって音を鳴らす
				if(other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag"){
					Debug.Log("ぶつかった");

					AudioSource audio = GetComponent<AudioSource>();
					audio.Play(0);
				}
                
        }
}