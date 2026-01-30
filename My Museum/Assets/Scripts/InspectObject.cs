using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class InspectObject : MonoBehaviour, IDragHandler
{
    public Transform model3D;
    public float tocDoXoay = 0.3f;
    private float yaw;   // xoay ngang (Y)
    private float pitch; // xoay dọc (X)
    public void UpdateModel(Transform model)
    {
        model3D = model;
        yaw = 0f;
        pitch = 0f;
    }
    public void ClearModel()
    {
        model3D = null;
    }
    public void OnDrag(PointerEventData data)
    {
        if (model3D == null) return;

        yaw -= data.delta.x * tocDoXoay;
        pitch += data.delta.y * tocDoXoay;

        model3D.localRotation = Quaternion.Euler(pitch, yaw, 0f);

    }
}
