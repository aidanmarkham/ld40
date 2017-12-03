using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIItem : MonoBehaviour {
    public float lerp;
    public GameObject dial;
    public float arrivalThreshold;
    public int resourceIndex;
    public Inventory inv;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += (dial.transform.position - transform.position) * lerp;
        if((dial.transform.position - transform.position).magnitude < arrivalThreshold)
        {
            inv.values[resourceIndex]++;
            Destroy(gameObject);
        }
	}
}
