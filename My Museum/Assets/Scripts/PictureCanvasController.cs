using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureCanvasController : MonoBehaviour
{
    public GameObject canvas;

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
        }
    }
}
