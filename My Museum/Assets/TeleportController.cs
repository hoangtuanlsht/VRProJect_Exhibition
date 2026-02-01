using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    [SerializeField] public Rigidbody playerRb;
    public void Teleport(Transform teleportTarget)
    {
        playerRb.velocity = Vector3.zero;
        playerRb.angularVelocity = Vector3.zero;
        playerRb.position = teleportTarget.position;
    }
}
