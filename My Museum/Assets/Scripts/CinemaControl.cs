using UnityEngine;
using UnityEngine.Video; // Bắt buộc phải có dòng này để dùng Video

public class CinemaControl : MonoBehaviour
{
    public VideoPlayer manHinhVideo; // Kéo cái Video Player vào đây
    private bool isPlayerInZone = false; // Biến kiểm tra người chơi có trong rạp không

    void Update()
    {
        // Kiểm tra: Nếu người chơi đang ở trong rạp VÀ bấm phím P
        if (isPlayerInZone && Input.GetKeyDown(KeyCode.P))
        {
            if (manHinhVideo.isPlaying)
            {
                manHinhVideo.Pause(); // Đang chạy thì tạm dừng
            }
            else
            {
                manHinhVideo.Play(); // Đang dừng thì phát tiếp
            }
        }
    }

    // Khi người chơi bước vào vùng Trigger
    void OnTriggerEnter(Collider other)
    {
        // Kiểm tra xem cái đi vào có phải là Player không (Nhớ đặt Tag "Player" cho nhân vật nhé)
        if (other.CompareTag("Player") || other.name.Contains("Player"))
        {
            isPlayerInZone = true;
            Debug.Log("Đã vào rạp! Bấm P để xem phim."); // Hiện thông báo để test
        }
    }

    // Khi người chơi đi ra khỏi vùng Trigger
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.name.Contains("Player"))
        {
            isPlayerInZone = false;
            manHinhVideo.Stop(); // Ra khỏi rạp thì tắt phim luôn
        }
    }
}