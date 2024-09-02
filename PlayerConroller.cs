using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    // Start is called before the first frame update(ゲームを実行後に1度だけ処理される)
    void Start()
    {
        Application.targetFrameRate = 60; //アニメーションのフレームレートを60fpsに固定
    }

    // Update is called once per frame（フレームごとに毎回処理される）
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))  // ← キーが押されたら
        { 
            transform.Translate(-1, 0, 0); //X軸負の方向に1移動
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)) // → キーが押されたら
        {
            transform.Translate(1, 0, 0); //X軸正の方向に1移動
        }
    }
}
