using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject CanvasMap;
    public PlayerSetLocomotionController locomotionController;
    void Start()
    {
        locomotionController = FindObjectOfType<PlayerSetLocomotionController>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            CanvasMap.SetActive(true);
            locomotionController.SetFalseLocomotion();
        }
    }
}
