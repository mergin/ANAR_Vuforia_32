using UnityEngine;
using System.Collections;

public class GlowingColors : MonoBehaviour {

    public Material[] _materials;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float mettallic = Mathf.PingPong(Time.time, 1.0F);

        foreach (Material material in _materials)
        {
            material.SetFloat("_Metallic", mettallic);
        }
	}
}
