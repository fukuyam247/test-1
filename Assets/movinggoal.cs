using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movinggoal : MonoBehaviour
{
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 4.0f + initialPosition.x, initialPosition.y,initialPosition.z);
    }

}

