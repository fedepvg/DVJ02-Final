using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    public LayerMask RaycastLayer;
    public float RaycastDistance;

    Vector3 DestPosition;

    // Start is called before the first frame update
    void Start()
    {
        DestPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(mouseRay, out hit, RaycastDistance, RaycastLayer))
            {
                DestPosition = hit.point;
            }
        }
    }
}
