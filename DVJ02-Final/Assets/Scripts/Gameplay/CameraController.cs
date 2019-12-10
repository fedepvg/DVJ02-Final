using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 CameraOffset;
    public float ZLookOffset;
    public Transform PlayerTransform;

    void Update()
    {
        transform.position = PlayerTransform.position + Vector3.up * CameraOffset.y - PlayerTransform.forward * CameraOffset.z;
        transform.LookAt(PlayerTransform.position + PlayerTransform.forward * ZLookOffset);
    }
}
