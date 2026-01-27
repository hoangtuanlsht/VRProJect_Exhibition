using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    public Transform player; // Kéo XR Origin vào đây

    // Bạn muốn Map xoay theo hướng người nhìn hay cố định hướng Bắc?
    // Để true = Xoay theo người (mũi tên luôn chỉ lên trên).
    // Để false = Cố định (Hướng Bắc luôn ở trên).
    public bool rotateWithPlayer = true; 

    void Update()
    {
        if (player == null) return;

        // 1. DI CHUYỂN: Chỉ lấy X và Z của người chơi, giữ nguyên độ cao Y của Camera
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y; 
        transform.position = newPosition;
        Debug.Log("camera move");
        // 2. XOAY (Tùy chọn):
        if (rotateWithPlayer)
        {
            // Xoay camera theo hướng Y của người chơi
            Vector3 newRotation = transform.eulerAngles;
            newRotation.y = player.eulerAngles.y;
            transform.rotation = Quaternion.Euler(newRotation);
        }
    }
}