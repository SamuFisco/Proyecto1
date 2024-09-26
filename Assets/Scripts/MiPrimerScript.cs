using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    //Variables
    // EL tipo de Dato Nombre
    int miVariable = 0;

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
        miVariable = miVariable + 1;
        Debug.Log("Chocado con" + collision.gameObject.name);
        Debug.Log(" Veces que ha colisionado: " + miVariable + " " + gameObject.name);
    }
}
