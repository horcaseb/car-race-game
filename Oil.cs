using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : Powerup
{
    Jugador eljugador;
    float t;
    public Oil(Jugador _jugador) : base(_jugador)
    {
        eljugador = _jugador;
        t = 0;
    }
    public override void activar(float _tiempo)
    {
        while (t < _tiempo)
        {
            t += Time.deltaTime;

        }
    }
}
