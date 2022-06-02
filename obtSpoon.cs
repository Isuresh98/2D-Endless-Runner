using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obtSpoon : MonoBehaviour
{
    [SerializeField]private GameObject _obstacalPrefab;
    [SerializeField] private int MinX;
    [SerializeField] private int MaxX;
    [SerializeField] private int MinY;
    [SerializeField] private int MaxY;




    void Start()
    {
        InvokeRepeating("PrefabsSpoon", 1f, 1.5f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PrefabsSpoon()
    {
        GameObject GobjectPrefab = Instantiate(_obstacalPrefab, transform.position + new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY)), transform.rotation);
        Destroy(GobjectPrefab.gameObject, 25f);

     


    }
}
