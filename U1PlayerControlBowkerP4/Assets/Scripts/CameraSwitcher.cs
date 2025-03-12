using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1; // First Camera
    public Camera camera2; // Second Camera

    private void Start()
    {
        // Ensure the first camera is enabled, and the second is disabled at the start
        camera1.enabled = true;
        camera2.enabled = false;
    }

    private void Update()
    {
        // Check for user input to switch cameras (e.g., pressing the "C" key)
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCameras();
        }
    }

    private void SwitchCameras()
    {
        // Toggle the cameras' enabled state
        camera1.enabled = !camera1.enabled;
        camera2.enabled = !camera2.enabled;
    }
}

