using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour {
    public GameObject player;
    public GameObject gameManager;
    public float slurpThreshold;
    public float slurpSpeed;
    public float vanishThreshold;
    private float playerDist;


    private Vector3 nightTimePos;
    public Vector3 dayTimeOffset;

    public bool gettable;

    public GameObject tree;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        nightTimePos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        playerDist = (player.transform.position - transform.position).magnitude;

        if (playerDist < slurpThreshold && gameManager.GetComponent<DayNight>().time > .5 && gameManager.GetComponent<DayNight>().time < 1f)
        {
            transform.position += (player.transform.position - transform.position) * slurpSpeed * Time.deltaTime;
            if (playerDist < vanishThreshold)
            {
                player.GetComponent<OrbManager>().orbNumber++;
                Destroy(gameObject);
            }
        }

        else if(gettable)
        {

            transform.position = nightTimePos + dayTimeOffset * Mathf.Clamp(Mathf.Sin(gameManager.GetComponent<DayNight>().time * (2 * Mathf.PI)) * 2, 0, 1f);
        }
        else
        {
            transform.position = nightTimePos + dayTimeOffset;
        }

        
	}
}
