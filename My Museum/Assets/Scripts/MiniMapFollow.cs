using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player; 
    public bool rotateWithPlayer = true; 

    void Update()
    {
        if (player == null) return;

        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y; 
        transform.position = newPosition;
        if (rotateWithPlayer)
        {
            Vector3 newRotation = transform.eulerAngles;
            newRotation.y = player.eulerAngles.y;
            transform.rotation = Quaternion.Euler(newRotation);
        }
    }
}