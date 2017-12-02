using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour {

    [Range(0, 1)]
    public float time;

    public bool timeProgressionEnabled;
    public float timeProgressionSpeed;

    public Material starMat;
    public Color starColor;

    public GameObject sun;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timeProgressionEnabled) {
            time += timeProgressionSpeed * Time.deltaTime;
        }
        if(time > 1)
        {
            time = 0;
        }
        sun.transform.rotation = Quaternion.Euler(time * 360,0,0);

        starColor.a = -Mathf.Sin(time * (2 *  Mathf.PI));

        starMat.color = starColor;
	}
}
