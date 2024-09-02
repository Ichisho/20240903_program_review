using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 0.3f; //矢を生成する間隔
    float delta = 0;
    int px;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; //Time.deltaTimeには、フレームごとの経過時間があらかじめ入っている

        if(this.delta > this.span) //経過時間が、矢を生成する間隔を超えたら
        {
            this.delta = 0; //累積経過時間を0に戻し、
            GameObject go = Instantiate(arrowPrefab); //Instantiateメゾットにより、prefabを渡すと返り値としてそれ通りのオブジェクトが生成（今回は矢）
            px = Random.Range(-8, 10); //矢を降らせる場所（横軸）をランダムに決定

            go.transform.position = new Vector2(px, 10); //矢の位置を決定
        }
    }
}
