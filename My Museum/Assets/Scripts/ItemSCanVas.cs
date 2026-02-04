using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class ItemSCanVas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject buttonBack;
    
    public void Start()
    {
        buttonBack = canvas.transform.Find("ButtonBackGround").gameObject;
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
            buttonBack.SetActive(true);
        }
    }
}
