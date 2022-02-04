using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Powerup
{
    public bool on = false;
    public Jugador eljugador;
    float t;
    public Banana(Jugador _jugador) : base(_jugador)
    {
        eljugador = _jugador;
        t = 0;
    }

    private void FixedUpdate()
    {
        if (on == true)
        {
            activar(3);
        }
    }
    public override void activar(float _tiempo)
    {
       
    }

    public void OnCollisionEnter(Collision Bananaso)
    {
        on = true;
        if (Bananaso.gameObject.tag == "Player")
        {
            activar(3);
            Destroy(gameObject);
        }
    }
}
