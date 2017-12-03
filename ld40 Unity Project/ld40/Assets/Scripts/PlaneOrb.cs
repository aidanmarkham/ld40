using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneOrb : MonoBehaviour {
    public GameObject plane;
    public float slurpThreshold;
    public float slurpSpeed;
    public float vanishThreshold;
    private float planeDist;
    private GameObject gm;
    // Use this for initialization
    void Start () {
        plane = GameObject.FindGameObjectWithTag("Plane");
	}
	
	// Update is called once per frame
	void Update () {

        planeDist = (plane.transform.position - transform.position).magnitude;

        transform.position += (plane.transform.position - transform.position) * slurpSpeed * Time.deltaTime;
            if (planeDist < vanishThreshold)
            {
            plane.GetComponent<PlaneManager>().orbsGiven++;
                Destroy(gameObject);
            }
        
    }
}
