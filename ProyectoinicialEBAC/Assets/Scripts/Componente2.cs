using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{
    private void Awake()
    {
        
    }
    private void FixedUpdate()
    {
        // Cambiar el color 
        GetComponent<MeshRenderer>().material.color = Color.cyan;
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Componente1.miObjeto.name);
       
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
