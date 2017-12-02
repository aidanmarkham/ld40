using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telescope : MonoBehaviour {

    public Camera fpsCam;
    public GameObject overlay;

    public float fov;
    public float zoomFOV;

    public bool hasTelescope;
    public bool zoomed;
	// Use this for initialization
	void Start () {
        fpsCam.fieldOfView = fov;
        overlay.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        zoomed = Input.GetKey(KeyCode.LeftShift);

        if(hasTelescope && zoomed)
        {
            fpsCam.fieldOfView = zoomFOV;
            overlay.SetActive(true);
        }
        else
        {
            fpsCam.fieldOfView = fov;
            overlay.SetActive(false);
        }
        
	}
}
