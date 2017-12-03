using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destructable : MonoBehaviour {
    public new string name;
    public int hp;
    public GameObject uiItem;
    public Vector3 location;
    public Transform canvas;
    public GameObject toDestroy;
    public UnityEvent onDestroy;
    public OrbManager orbManager;
	// Use this for initialization
	void Start () {
        orbManager = GameObject.FindGameObjectWithTag("OrbManager").GetComponent<OrbManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (hp == 0)
        {
            Destroy(toDestroy);
            onDestroy.Invoke();
        }	
	}

    void GetHit() {
        hp--;
        if (uiItem != null)
        {
            GameObject go = (GameObject)Instantiate(uiItem, canvas);

            go.SetActive(true);
            go.transform.position = location;
        
        orbManager.orbsToRelease++;
        }
    }


}
