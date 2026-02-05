using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class ItemSCanVas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject buttonBack;
    public GameObject presentBack;
    
    public void Start()
    {
        buttonBack = canvas.transform.Find("ButtonBackGround").gameObject;
        presentBack = canvas.transform.Find("PresentBackGround").gameObject;
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
            presentBack.SetActive(false);
        }
    }
}
