using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessController : MonoBehaviour
{
    public OVRPassthroughLayer passthroughLayer; // The passthrough layer you want to control
    public float sensitivity = 0.1f; // How much the brightness should change per input
    // public TextMeshProUGUI brightnessText; // The text element that displays the brightness level

    void Update()
    {
        float input = Input.GetAxis("Vertical"); // Get the vertical input
        float weight = passthroughLayer.ColorLutWeight + input * sensitivity; // Change the weight
        weight = Mathf.Clamp(weight, 0, 1); // Clamp the weight between 0 and 1

        // Apply the new weight
        passthroughLayer.ColorLutWeight = weight;
       // passthroughLayer.ColorLutWeight = 0;


    }
}
