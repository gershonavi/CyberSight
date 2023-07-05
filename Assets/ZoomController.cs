using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour
{
    // The camera's initial FOV
    private float initialFOV;

    // The amount to change the FOV by each frame
    public float zoomSpeed = 0.2f;

    // The minimum and maximum FOV
    public float minFOV = 30f;
    public float maxFOV = 90f;

    void Start()
    {
        // Get the camera's initial FOV
        initialFOV = Camera.main.fieldOfView;
    }

    void Update()
    {
        // Get the user's input from the VR controller
        // This will depend on your specific setup
        // For this example, we'll use the vertical input axis
        float input = Input.GetAxis("Vertical");

        // Calculate the new FOV
        float newFOV = Camera.main.fieldOfView - input * zoomSpeed;

        // Clamp the new FOV to the minimum and maximum
        newFOV = Mathf.Clamp(newFOV, minFOV, maxFOV);

        // Set the camera's FOV
        Camera.main.fieldOfView = newFOV;
    }
}
