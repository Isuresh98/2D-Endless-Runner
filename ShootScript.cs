using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] private GameObject _shootSprits;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject _shootPC=Instantiate(_shootSprits, transform.position, transform.rotation);
            Destroy(_shootPC .gameObject, 3f);

        }
     


    }
  

}
