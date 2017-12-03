using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dial : MonoBehaviour {
    private Vector3 upPosition;
    public Vector3 downPositionOffset;
    public Text text;
    public Inventory inv;
    public int resourceIndex;
    private int amount;
    public float lerp;

    // Use this for initialization
    void Start () {
        upPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        amount = inv.values[resourceIndex];
        text.text = ""+amount;
        if (amount <1)
        {
            transform.position += ((upPosition + downPositionOffset) - transform.position) * lerp;
        }
        else
        {
            transform.position += (upPosition - transform.position) * lerp;
        }
	}
}
