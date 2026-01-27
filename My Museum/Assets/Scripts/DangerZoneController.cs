using UnityEngine;



public class DangerZoneController : MonoBehaviour

{

    [Header("Alarm Components")] // Tiêu đề trong Inspector

    public AudioSource alarmSound; // Biến âm thanh (Còi hú)

    public Light alarmLight;       // Biến ánh sáng (Đèn báo động)

    public GameObject bienBaoCam; // MỚI: Biến để chứa cái Canvas biển báo

   

    [Header("Settings")]

    public float blinkSpeed = 10f; // Tốc độ nháy đèn



    // Biến nội bộ dùng để kiểm tra trạng thái (Private thì không hiện ra Inspector)

    private bool isIntruderDetected = false;



    void Update()

    {

        // Logic điều khiển đèn: Nếu có người -> Nhấp nháy

        if (isIntruderDetected && alarmLight != null)

        {

            // Hàm PingPong tạo giá trị dao động từ 0 đến 2 liên tục

            alarmLight.intensity = Mathf.PingPong(Time.time * blinkSpeed, 2f);

        }

        else if (alarmLight != null)

        {

            // Không có người -> Tắt hẳn đèn

            alarmLight.intensity = 0;

        }

    }



    // Sự kiện: Khi có vật thể đi vào vùng Trigger

    private void OnTriggerEnter(Collider other)

    {

        Debug.Log("Có cái gì đó vừa đi vào: " + other.gameObject.name);

        // Kiểm tra Tag của vật thể đó có phải là "Player" không

        if (other.CompareTag("Player"))

        {

            isIntruderDetected = true; // Bật cờ báo động

           

            if (alarmSound) alarmSound.Play(); // Bật âm thanh

            // MỚI: Hiện biển báo lên

            if (bienBaoCam != null) bienBaoCam.SetActive(true);

            Debug.Log("ALERT: Intruder detected inside the Danger Zone!");

        }

    }



    // Sự kiện: Khi vật thể đi ra khỏi vùng Trigger

    private void OnTriggerExit(Collider other)

    {

        if (other.CompareTag("Player"))

        {

            isIntruderDetected = false; // Tắt cờ báo động

           

            if (alarmSound) alarmSound.Stop(); // Tắt âm thanh

            // MỚI: Ẩn biển báo đi

            if (bienBaoCam != null) bienBaoCam.SetActive(false);

            Debug.Log("Safe: Intruder left the area.");

        }

    }

}