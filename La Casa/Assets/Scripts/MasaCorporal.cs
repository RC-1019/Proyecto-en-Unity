using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasaCorporal : MonoBehaviour
{
    public string nombreUsuario;
    public float alturaCentimetros;
    public int pesoKilos;
    private float altura2;
    private float IMC;


    // Start is called before the first frame update
    void Start()
    {
        float altura2 = alturaCentimetros * alturaCentimetros;
        float IMC = pesoKilos / altura2;
        Debug.Log("Nombre de usuario: " + nombreUsuario);
        Debug.Log("Altura: " + alturaCentimetros);
        Debug.Log("Peso: " + pesoKilos);
        Debug.Log("Su indice de masa corporal es: " + IMC);

        if (IMC <= 18.6 || IMC >= 25.0)
        {
            Debug.Log("Correcto");
        }
        else
        {
            Debug.Log("Incorrecto");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
