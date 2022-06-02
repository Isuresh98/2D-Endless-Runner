using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFalow : MonoBehaviour
{
    [SerializeField]
    private float _camSpeed = 1f;
   

    void Update()
    {
        transform.position += new Vector3(_camSpeed *Time.deltaTime, 0,0);
    }
}
