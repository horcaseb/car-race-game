using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public bool banana = false;
    public int posicion =0;
    public GameObject trampa;
    float tiempo;
    public Transform mtransform;
    Rigidbody mcuerpo;
    bool choque;

    public float mag;
    void Start()
    {
        choque = false;
        tiempo = 0;
        mtransform = GetComponent<Transform>();
        mcuerpo = GetComponent<Rigidbody>();
    }
    [SerializeField] Trampa creadortrampa;

    public string[] control = new string[3];
    int[] intcontrol = { 0, 1 };

    
    private void FixedUpdate()
    {
        if (banana == true)
        {
            BananaOn();
        }
        else
        {
            Movrot(); 
        }
        if (choque == true)
        {
            tiempo += Time.deltaTime;
            if (tiempo >= 3)
            {
                choque = false;
                mag = 8;
                tiempo = 0;
            }
        }
        if (Input.GetButtonDown(control[2]))
        {
            creadortrampa.PonerTrampa(trampa);
        }
    }
    
    public void Movrot()
    {
        if (banana == false)
        {
            //desplazamiento Z
            Vector3 dirZ = mtransform.forward;
            float senZ = Input.GetAxis(control[0]);
            Vector3 velZ = mag * dirZ * senZ;
            Vector3 desplazamientoZ = (velZ) * Time.deltaTime;
            mtransform.position += desplazamientoZ;

            //rotacion Y       
            float magAng = 90;
            Vector3 dirAng = new Vector3(0, 1, 0);
            float senAng = Input.GetAxis(control[1]);
            Vector3 velAng = magAng * dirAng * senAng;
            Vector3 desplazamientoAng = (velAng) * Time.deltaTime;
            mtransform.eulerAngles += desplazamientoAng;
        }
    }

    private void OnCollisionEnter(Collision barrera)
    {
        choque = true;
        if (barrera.gameObject.tag == "barrera" )
        {
            tiempo = 0;
            mag = mag / 1.4f;
        }
        
    }

    public void BananaOn()
    {
        string temp;
       for(int i = 0; i < 1; i++)
       {
          if (intcontrol[i] < intcontrol[i++])
          {
              temp = control[i];
              control[i] = control[i++];
          }
        }
    }

    public void Oil()
    {

    }

    public void Trampa()
    {
    }
}
