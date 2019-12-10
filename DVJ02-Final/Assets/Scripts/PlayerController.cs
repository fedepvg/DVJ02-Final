using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    public LayerMask RaycastLayer;
    public float RaycastDistance;
    public GameObject Target;
    public float LerpMultiplier;

    Vector3 DestPosition;
    bool Moving = false;
    Rigidbody Rb;
    float LerpTimer;
    Vector3 PrevNormal;

    // Start is called before the first frame update
    void Start()
    {
        DestPosition = transform.position;
        Target.transform.position = DestPosition;
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(mouseRay, out hit, RaycastDistance, RaycastLayer))
            {
                DestPosition = hit.point;
                Target.transform.position = DestPosition;
                Moving = true;
            }
        }

        if (Moving)
        {
            if (Physics.Raycast(transform.position, -transform.up, out hit, RaycastDistance, RaycastLayer))
            {
                if (hit.normal != PrevNormal)
                    LerpTimer = 0;
                else if (LerpTimer >= 1)
                    LerpTimer = 1;
                LerpTimer += LerpMultiplier * Time.deltaTime;
                transform.position += transform.forward * MovementSpeed * Time.deltaTime;
                Quaternion destRot = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
                transform.rotation = Quaternion.Lerp(transform.rotation, destRot, LerpTimer);
                PrevNormal = hit.normal;

                Vector3 target = new Vector3(Target.transform.position.x, transform.position.y, Target.transform.position.z);
                Quaternion lookRot = Quaternion.LookRotation(target - transform.position);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRot, RotationSpeed);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Moving = false;
        Rb.velocity = Vector3.zero;
    }
}
