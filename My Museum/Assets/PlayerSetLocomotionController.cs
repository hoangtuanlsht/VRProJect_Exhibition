using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem.XR;
public class PlayerSetLocomotionController : MonoBehaviour
{
    public GameObject Player;
    public TrackedPoseDriver tpd;
    private void Start()
    {
        tpd = Player.GetComponent<UnityEngine.InputSystem.XR.TrackedPoseDriver>();
        
    }
    public void SetFalseLocomotion()
    {
        if (tpd != null)
            tpd.enabled = false;
    }
    public void SetTrueLocomotion()
    {
        if(tpd != null)
            tpd.enabled = true;
    }
}
