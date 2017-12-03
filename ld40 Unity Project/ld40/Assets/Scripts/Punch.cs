using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour {
    public float maxDist;
    public GameObject currentTarget;
    public GameObject punchIcon;
	// Use this for initialization
	void Start () {
        punchIcon.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit) && hit.distance < maxDist)
        {
            if(hit.transform.tag == "Destructable") {
                currentTarget = hit.transform.gameObject;
                punchIcon.SetActive(true);
                if(Input.GetMouseButtonDown(0))
                {
                    hit.transform.gameObject.BroadcastMessage("GetHit");
                }
            }
            
        }
        else
        {
            punchIcon.SetActive(false);
            currentTarget = null;
        }
        
	}
}
