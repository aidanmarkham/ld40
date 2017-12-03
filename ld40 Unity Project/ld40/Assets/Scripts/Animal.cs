using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
    public CharacterController cc;
    public float speed;
    public float rotation;
    public float rotationSpeed;
    public float rotDampening;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
        rotationSpeed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        rotationSpeed += Random.Range(-1.0f, 1.0f);

        rotationSpeed *= rotDampening;

        rotationSpeed = Mathf.Clamp(rotationSpeed, -7, 7);
        transform.Rotate(new Vector3(0,0,rotationSpeed * rotation * Time.deltaTime));
        cc.SimpleMove(transform.right * speed * Time.deltaTime);
	}
}
