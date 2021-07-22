using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform vehicle;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - vehicle.position;
        Debug.Log(offset);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = vehicle.position + offset;
    }
}