using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{ 


 private void OnTriggerEnter2D(Collider2D Collition)
{

  
    if (Collition.gameObject.tag == "Playar")
    {

        Destroy(this.gameObject);
    }

}
}// class
