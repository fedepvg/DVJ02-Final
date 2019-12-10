using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    float RayDistance = 100;

    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, RayDistance))
        {
            transform.position = hit.point;
            transform.position += Vector3.up * transform.localScale.y / 2;
        }
    }
}
