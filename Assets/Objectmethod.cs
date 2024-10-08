using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectmethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //このスクリプトを与えられたオブジェクトがtag”プレイヤー”に当たったら「当てられたオブジェクトを」消す
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject,0.5f);
        }
    }
}
