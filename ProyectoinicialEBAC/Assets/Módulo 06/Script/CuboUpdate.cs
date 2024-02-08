using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{
    public GameObject PrefabCubo;
       
    void Update()
    {
        var GameObject = Instantiate(PrefabCubo);
    }
}
