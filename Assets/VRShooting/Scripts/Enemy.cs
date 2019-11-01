using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //　OnHitBulletメッセージから呼び出されることを想定
    void OnHitBullet()
    {
        //　自身のゲームオブジェクトを破壊
        Destroy(gameObject);
    }
}
