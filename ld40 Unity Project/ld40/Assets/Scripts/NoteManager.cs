using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteManager : MonoBehaviour {

    public int textIndex;
    private int oldTextIndex;
    public Text text;
    private GameObject gm;
	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager");
        SetText(textIndex);
	}
	
	// Update is called once per frame
	void Update () {
		if(textIndex != oldTextIndex)
        {
            SetText(textIndex);
        }
        oldTextIndex = textIndex;
	}

    void SetText(int i)
    {
        text.text = gm.GetComponent<Dialogues>().dialogues[i];
    }
}
