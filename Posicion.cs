using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour
{
    public Jugador[] jugadores;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < jugadores.Length; i++)
        {
            jugadores[i].posicion = 2;
            if (collision.gameObject == jugadores[i])
            {
                collision.gameObject.GetComponent<Jugador>().posicion = 1;
            }
            else
            {
                jugadores[i].posicion = 2;
            }
        }
        Destroy(gameObject);
    }
}
