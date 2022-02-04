using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    MeshRenderer objeto;
    BoxCollider caja;
    public GameObject[] trampas;
    int numero;
    public GameObject[] corredores;
    [SerializeField] GameObject[] primero;

    // Use this for initialization
    public Trampa( )
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void PonerTrampa( GameObject _powerup)
    {
        
        objeto = GetComponent<MeshRenderer>();
        caja = GetComponent<BoxCollider>();

        
        try
        {
            Instantiate(_powerup, primero[0].transform.GetChild(0).position, Quaternion.identity);
        }
        catch { }
    }
}
