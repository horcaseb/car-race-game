using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : Powerup
{
    Jugador eljugador;
    float t;
    public Boost(Jugador _jugador) : base(_jugador)
    {
        eljugador = _jugador;
        t = 0;
    }
    public void Update()
    {
        activar(3);
    }
    public override void activar(float _tiempo)
    {
        while (t < _tiempo)
        {
            t += Time.deltaTime;
            eljugador.mag*=2;
        }
        eljugador.mag*=0.5f;
    }
}
