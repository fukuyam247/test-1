using UnityEngine;
using System.Collectiopns;

public class PingPongVertical : MonoBehaviour
{
   
    [SerializeField] private float _length = 1;

    private void Update()
    {
        
        var value = Mathf.PingPong(Time.time, _length);

       
        transform.localPosition = new Vector3(0, 0 , value);
    }
}
