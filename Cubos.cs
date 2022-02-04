using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubos : MonoBehaviour
{
    GameObject poder;
    public GameObject[] poderes;
    public int powerup;
    public Cubos()
    {
        
    }
    private void OnCollisionEnter(Collision cajamisteriosa)
    {
        if (cajamisteriosa.gameObject.tag == "Player")
        {
            int dado = Random.Range(0, 3);
            poder = poderes[dado];
            powerup = dado;
            Destroy(gameObject);
            Debug.Log(dado);
            cajamisteriosa.gameObject.GetComponent<Jugador>().trampa=poder;
        }
        
    }
}
