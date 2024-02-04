using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo");
        x = 0;
        print("Something happened");

        Debug.LogWarning("Something went moderately wrong");
        Debug.LogError("Something went very wrong");
    }
    
    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El Oobjeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El Objeto ha sido inhabilitado");
    }

}
