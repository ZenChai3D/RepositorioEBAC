using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CuboOnOff : MonoBehaviour
{
    public GameObject PrefabCubo;
       

    void OnEnable()
    {
        var GameObject = Instantiate(PrefabCubo);

    }
        // Update is called once per frame
    void OnDisable()
    {
        if (PrefabCubo != null)
        {
            Destroy(PrefabCubo, 2f);
        }
       
    }
}


