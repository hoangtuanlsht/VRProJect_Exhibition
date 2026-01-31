using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCanvasController : MonoBehaviour
{
    public GameObject canvas;
    public PlayerSetLocomotionController locomotionController;
    public Vector3 scale = new Vector3(1f, 1f, 1f);
    public Vector3 rotation = new Vector3(0f, 0f, 0f);
    public void Start()
    {
        locomotionController = FindObjectOfType<PlayerSetLocomotionController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            canvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            canvas.SetActive(false);
            locomotionController.SetTrueLocomotion();
        }
    }
}
