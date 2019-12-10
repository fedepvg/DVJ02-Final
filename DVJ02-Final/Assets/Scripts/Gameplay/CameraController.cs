using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float YOffset;
    public float ZOffset;
    public float ZLookOffset;
    public Transform PlayerTransform;

    void Update()
    {
        transform.position = PlayerTransform.position + Vector3.up * YOffset - PlayerTransform.forward * ZOffset;
        transform.LookAt(PlayerTransform.position + PlayerTransform.forward * ZLookOffset);
    }
}
