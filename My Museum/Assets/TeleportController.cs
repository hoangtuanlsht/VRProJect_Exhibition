using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    [SerializeField] public GameObject Player;
    public void Teleport(GameObject teleportTarget)
    {
        Player.transform.position = teleportTarget.transform.position;
    }
}
