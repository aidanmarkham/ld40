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
    public AudioSource[] daySounds;
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

        starColor.a = Mathf.Clamp(-Mathf.Sin(time * (2 *  Mathf.PI))* 3, 0, 1);
        sun.GetComponent<Light>().intensity = Mathf.Clamp(Mathf.Sin(time * (2 * Mathf.PI)) * 3, 0, .69f);
        for(int i = 0; i < daySounds.Length; i++)
        {
            daySounds[i].volume = Mathf.Clamp(Mathf.Sin(time * (2 * Mathf.PI)) * 1, 0, .69f);
        }
        starMat.color = starColor;
	}
}
