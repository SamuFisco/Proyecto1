using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public Vector3 speedRotation; //Variable de velocidad de la moneda
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedRotation * Time.deltaTime, Space.World); //Space.World hace que rote respecto al mundo
    }
}
