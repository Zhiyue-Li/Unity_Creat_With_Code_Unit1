using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    // Switch Camera
    public void SwitchCamera() {
        firstPersonCamera.enabled = !firstPersonCamera.enabled;
        overheadCamera.enabled = !overheadCamera.enabled;
    }

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }
}
