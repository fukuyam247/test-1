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

    //���̃X�N���v�g��^����ꂽ�I�u�W�F�N�g��tag�h�v���C���[�h�ɓ���������u���Ă�ꂽ�I�u�W�F�N�g���v����
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject,0.5f);
        }
    }
}
