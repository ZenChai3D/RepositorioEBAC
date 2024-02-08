using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAwake : MonoBehaviour
{
   public GameObject PrefabCubo;

    private void Awake()
    {
        var GameObject = Instantiate(PrefabCubo);
        
    }


}
