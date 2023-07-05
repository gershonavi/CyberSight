using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.XR;

public class PassthroughSetup : MonoBehaviour
{
    void Start()
    {
        // Get the existing OVROverlay component or add one if it doesn't exist
        OVROverlay overlay = this.gameObject.GetComponent<OVROverlay>();
        if (overlay == null)
        {
            overlay = this.gameObject.AddComponent<OVROverlay>();
        }

        // Set the overlay type to Overlay
        //overlay.currentOverlayType = OVROverlay.OverlayType.Overlay;
        //adb shell settings put system screen_brightness
        //

        overlay.currentOverlayType = OVROverlay.OverlayType.Underlay;

        // Set the overlay shape to Quad
        overlay.currentOverlayShape = OVROverlay.OverlayShape.Quad;

    }
}


/*

public class PassthroughSetup : MonoBehaviour
{
    void Start()
    {
 
        // Create a new game object
        GameObject passthroughObject = new GameObject("Passthrough");

        // Add an OVROverlay component to the game object
        OVROverlay overlay = passthroughObject.AddComponent<OVROverlay>();

        // Set the overlay type to Underlay
        // adb shell setprop debug.oculus.experimentalEnabled 1
        overlay.currentOverlayType = OVROverlay.OverlayType.Overlay;

        // Set the overlay shape to Quad
        overlay.currentOverlayShape = OVROverlay.OverlayShape.Quad;
    }
}

*/