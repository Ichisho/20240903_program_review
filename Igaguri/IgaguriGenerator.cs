using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //マウスがクリックされたら
        {
            GameObject igaguri = Instantiate(igaguriPrefab); //prefabに従って生成されるオブジェクトを代入
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //スクリーン座標系をワールド座標系に落とし込む
            Vector3 worldDir = ray.direction; //rayのベクトルを取得
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 2000); //directionを長さ1のベクトルに正規化、2000の力をかける
        }
    }
}
