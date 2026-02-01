using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject CanvasMap;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            CanvasMap.SetActive(true);
        }
    }
}
