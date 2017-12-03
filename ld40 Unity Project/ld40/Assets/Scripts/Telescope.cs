using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Telescope : MonoBehaviour {

    public CinemachineVirtualCamera fpsCam;
    public GameObject overlay;

    public float fov;
    public float zoomFOV;

    public bool hasTelescope;
    public bool zoomed;
	// Use this for initialization
	void Start () {
        fpsCam.m_Lens.FieldOfView = fov;
        overlay.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        zoomed = Input.GetKey(KeyCode.LeftShift);

        if(hasTelescope && zoomed)
        {
            fpsCam.m_Lens.FieldOfView = zoomFOV;
            overlay.SetActive(true);
        }
        else
        {
            fpsCam.m_Lens.FieldOfView = fov;
            overlay.SetActive(false);
        }
        
	}

    public void EnableTelescope()
    {
        hasTelescope = true;
    }
}
