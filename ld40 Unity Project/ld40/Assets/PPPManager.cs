using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;


public class PPPManager : MonoBehaviour
{
    public PostProcessingProfile aboveWater;
    public PostProcessingProfile underWater;
    public PostProcessingBehaviour PPB;
    public float level;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < level)
        {
            PPB.profile = underWater;
        }
        else
        {
            PPB.profile = aboveWater;
        }
	}
}
