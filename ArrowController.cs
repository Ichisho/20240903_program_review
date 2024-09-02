using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player; //プレイヤーのオブジェクトを代入する変数(GameObject型)
    
    //あらかじめ用意されている、Vectorクラス。座標を代入できる
    Vector2 p1; //矢の座標
    Vector2 p2; //プレイヤーの座標

    Vector2 dir; 
    
    float r1 = 0.5f; //矢の半径、以後矢のオブジェクトを円形のものと仮定
    float r2 = 1.0f; //プレイヤーの半径、プレイヤーのオブジェクトについても円形と仮定
    float d;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player"); //playerオブジェクトを代入
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if(transform.position.y < -10.0f) //矢のy座標が-10.0を超えたら
        {
            Destroy(gameObject); //矢を消去
        }
        
        //矢とプレイヤーの当たり判定処理
        p1 = transform.position;               //矢の座標を代入
        p2 = this.player.transform.position;   //プレイヤーの座標を代入
        dir = p1 - p2;                         //矢とプレイヤーの座標の差を代入
        d = dir.magnitude;                     //座標の差の絶対値を計算、これが矢とプレイヤー間の距離になる

        
        if(d < r1 + r2) //矢とプレイヤー間の距離が、それぞれの半径を足し合わせたものよりも小さければ、当たったと判定
        {
            GameObject director = GameObject.Find("GameDirector"); //GameDirectorを呼び出し、
            director.GetComponent<GameDirector>().DecreaseHp(); //スクリプト内のDecreaseHp関数を用いている
            
            //衝突した場合は矢を消す
            Destroy(gameObject);
        }
    }
}
