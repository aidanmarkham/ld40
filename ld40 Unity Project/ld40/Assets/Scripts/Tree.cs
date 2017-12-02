using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {


    public float minSize;
    public float maxSize;

    public GameObject orb;
	// Use this for initialization
	void Start () {


        transform.localScale = transform.lossyScale * Random.Range(minSize, maxSize);

        transform.rotation = Quaternion.Euler(0, Random.Range(0, 359), 0);
 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
