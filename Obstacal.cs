using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacal : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D Collition)
    {

        if (Collition.gameObject.tag == "Playar")
        {

            transform.localScale += new Vector3(0.1f, 0.1f, 0);

        }

        else if (Collition.gameObject.tag == "bulat")
        {

            Destroy(this.gameObject);
        }

    }
}// class






