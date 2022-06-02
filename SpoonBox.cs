using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoonBox : MonoBehaviour
{

    [SerializeField] private GameObject _boxlPrefab;
    [SerializeField] private int MinX;
    [SerializeField] private int MaxX;
    [SerializeField] private int MinY;
    [SerializeField] private int MaxY;




    void Start()
    {
        InvokeRepeating("PrefabsSpoon", 0.1f, 5f);


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void PrefabsSpoon()
    {
        GameObject GobjectPrefab = Instantiate(_boxlPrefab, transform.position + new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY)), transform.rotation);
        Destroy(GobjectPrefab.gameObject, 25f);




    }
}
