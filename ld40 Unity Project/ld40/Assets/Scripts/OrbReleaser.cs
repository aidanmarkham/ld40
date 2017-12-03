using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbReleaser : MonoBehaviour {
    public GameObject plane;
    public GameObject planeOrb;

    public float threshold;
    public float frequency;
    private float timer;
    public Inventory inv;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((transform.position - plane.transform.position).magnitude < threshold)
        {
            Debug.Log("inpos");
            timer += Time.deltaTime;
            if(timer > frequency && inv.values[3] > 0)
            {
                Debug.Log("dispencis");
                timer = 0;
                inv.values[3]--;
                Instantiate(planeOrb,transform.position, transform.rotation).SetActive(true);
            }
        }
	}
}
