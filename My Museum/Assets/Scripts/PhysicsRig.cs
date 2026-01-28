using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class PhysicsRig : MonoBehaviour
{
    public Transform playerHead;
    public CapsuleCollider bodyCollider;

    //public Transform leftController;
    //public Transform rightController;

    //public ConfigurableJoint headJoint;
    //public ConfigurableJoint leftHandJoint;
    //public ConfigurableJoint rightHandJoint;

    public float bodyHeightMin = 1f;
    public float bodyHeightMax = 2.0f;

    void FixedUpdate()
    {
        bodyCollider.height = Mathf.Clamp(playerHead.localPosition.y, bodyHeightMin, bodyHeightMax);
        bodyCollider.center = new Vector3(playerHead.localPosition.x, bodyCollider.height / 2.0f,
            playerHead.localPosition.z);

        //leftHandJoint.targetPosition = leftController.localPosition;
        //leftHandJoint.targetRotation = leftController.localRotation;

        //rightHandJoint.targetPosition = rightController.localPosition;
        //rightHandJoint.targetRotation = rightController.localRotation;

        //headJoint.targetPosition = playerHead.localPosition;
    }
}
