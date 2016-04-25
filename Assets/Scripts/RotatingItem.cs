using UnityEngine;
using System.Collections;

public class RotatingItem : MonoBehaviour {

    public int rotationFactor = 0;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, Time.deltaTime*rotationFactor, 0));
	}
}
