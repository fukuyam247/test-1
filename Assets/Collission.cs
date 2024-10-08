using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
    public float bounce = 10f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
           other.rigidbody.AddForce(0f, bounce, bounce / 2, ForceMode.Impulse);
        }
    }
}
