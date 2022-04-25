using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript : MonoBehaviour
{
    public string mensajeBienvenida;
    public string miNombre1;
    public string miNombre2;
    public int edad1;
    public int edad2;
    public bool estaArriba;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo mi nombre es:" + miNombre1 + miNombre2);
        Debug.Log(edad1 + edad2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump() 
    {
    
    }
}
