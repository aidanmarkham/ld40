using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeWindRandom : MonoBehaviour {
    public float minSpeed;
    public float maxSpeed;
    public Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.SetFloat("Speed", Random.Range(minSpeed, maxSpeed));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
