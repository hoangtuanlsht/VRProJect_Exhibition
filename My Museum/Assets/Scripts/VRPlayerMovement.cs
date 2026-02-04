using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRPlayerMovement : MonoBehaviour
{
    [Header("References")]
    public XROrigin xrOrigin;        // XR Origin
    public Rigidbody playerBody;     // Capsule Rigidbody

    [Header("Movement")]
    public float speed = 2f;

    private Vector3 moveDir;

    void Update()
    {
        // Ví dụ: dùng bàn phím để test (WASD)
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Hướng di chuyển theo hướng nhìn của HMD (camera)
        Transform cam = xrOrigin.Camera.transform;

        Vector3 forward = new Vector3(cam.forward.x, 0, cam.forward.z).normalized;
        Vector3 right = new Vector3(cam.right.x, 0, cam.right.z).normalized;

        moveDir = forward * v + right * h;
    }

    void FixedUpdate()
    {
        if (moveDir.sqrMagnitude < 0.001f) return;

        Vector3 targetPos =
            playerBody.position + moveDir * speed * Time.fixedDeltaTime;

        playerBody.MovePosition(targetPos);
    }

    void LateUpdate()
    {
        // XR Origin bám theo body (chỉ XZ, giữ nguyên Y)
        Vector3 bodyPos = playerBody.position;

        xrOrigin.transform.position = new Vector3(
            bodyPos.x,
            xrOrigin.transform.position.y,
            bodyPos.z
        );
    }
}
