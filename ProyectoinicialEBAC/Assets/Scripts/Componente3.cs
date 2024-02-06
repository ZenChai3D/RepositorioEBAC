using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Componente1.miObjeto.name = "nuevoNombreDeMiObjeto";
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)); 
        GetComponent<MeshRenderer>().material.color = c;
    }
}
