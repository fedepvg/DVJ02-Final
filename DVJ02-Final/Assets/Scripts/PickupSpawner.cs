using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public int MaxPickups;
    public GameObject PickupPrefab;
    public Transform LeftLimit;
    public Transform RightLimit;
    public Transform UpLimit;
    public Transform DownLimit;
    public float YPos;

    List<GameObject> PickupList;

    void Start()
    {
        PickupList = new List<GameObject>();
        for (int i = 0; i < MaxPickups; i++)
        {
            GameObject go = Instantiate(PickupPrefab, transform);
            Vector3 newPos = new Vector3(Random.Range(LeftLimit.position.x, RightLimit.position.x),
                                        YPos,
                                        Random.Range(DownLimit.position.z, UpLimit.position.z));
            go.transform.position = newPos;
            PickupList.Add(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
