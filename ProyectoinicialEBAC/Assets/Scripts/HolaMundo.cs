using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo");
=======
    int x;
    // Start is called before the first frame update
    void Start()
    {
        x=0;
        print("Something happened");

        Debug.LogWarning("Something went moderately wrong");
        Debug.LogError("Something went very wrong");
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
        //x = x + 1;
        // Debug.Log(x);

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
        Debug.LogWarning("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto inhabilitado");
>>>>>>> Stashed changes
    }
}
