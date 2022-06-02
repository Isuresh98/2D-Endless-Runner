using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayarScript : MonoBehaviour

{
    public Text Helth;

    [SerializeField] private float _playarSpeed = 3f;
    public Rigidbody2D rBody;
    private Vector2 _playarDiracaction;
    [SerializeField] private int _playarHelth = 3;
    public GameObject Playar;
   
    


    private void Update()
    {
        float _verticalInput = Input.GetAxis("Vertical");
   
        _playarDiracaction = new Vector2(0, _verticalInput);

        Helth.text = "Helth Count:" + _playarHelth;


    }//Update
    private void FixedUpdate()
    {
        rBody.velocity = new Vector2(0, _playarDiracaction.y * _playarSpeed);
       


    }//FixedUpdate 

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Obstacal")
        {
            _playarHelth -= 1;
            if (_playarHelth == 0)
            {
                Playar.SetActive(false);

            }

        }
        if (collision.gameObject.tag == "Box")
        {
            _playarHelth += 1;
        }

    }

}