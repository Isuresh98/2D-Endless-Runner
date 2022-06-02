using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolatTrans : MonoBehaviour
{
    [SerializeField] private float _bollatSpeed =5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(_bollatSpeed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Obstacal")
        {
             Destroy(this.gameObject);
            
        }

    }
}
