using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManager : MonoBehaviour {
    [Range(0, 1)]
    public float progress;
    public int totalOrbsNeeded;
    public int orbsGiven;
    public Transform brokenLoc;
    public Transform fixedLoc;

    public SkinnedMeshRenderer renderer;
	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
        progress = (float)orbsGiven / totalOrbsNeeded;

        transform.position = Vector3.Lerp(brokenLoc.position, fixedLoc.position, progress);
        transform.localScale = Vector3.Lerp(brokenLoc.localScale, fixedLoc.localScale, progress);
        transform.rotation = Quaternion.Lerp(brokenLoc.rotation, fixedLoc.rotation, progress);

        renderer.SetBlendShapeWeight(0, 100 - (progress * 100));
	}
}
