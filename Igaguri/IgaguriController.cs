using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60; //アニメーションのフレームレートを60fpsに固定
        //Shoot(new Vector3(0, 200, 2000)); //実行した直後、Shootメゾットが実行される
    }

    void OnCollisionEnter(Collision collision) //的とイガグリが衝突した際に、イガグリに働く力を無効化する
    {
        GetComponent<Rigidbody>().isKinematic= true;
    }
    public void Shoot(Vector3 dir) //このスクリプトが与えられたオブジェクトに、XYZ方向の力を与えるメゾット
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    
}
