using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbManager : MonoBehaviour {

    [SerializeField]
    public List<GameObject> orbs;
    public GameObject orbHolder;
    public GameObject[] obsArray;
    public DayNight dn;
    public int orbsToRelease;
	// Use this for initialization
	void Start () {

        foreach (Transform child in transform)
        {
            orbs.Add(child.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (dn.time > 0.4 && dn.time < .45)
        {
            ReleaseOrbs(orbsToRelease);
            orbsToRelease = 0;
        }
	}

    void ReleaseOrbs(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, orbs.Count);
            orbs[index].SetActive(true);
            orbs[index].GetComponent<Orb>().gettable = true;
            orbs.RemoveAt(index);
        }
        
    }
}
