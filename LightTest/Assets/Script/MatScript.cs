using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatScript : MonoBehaviour {
    private MeshRenderer r;
    //public Material mat2;
    // Use this for initialization
    void Start () {
        r = GetComponent<MeshRenderer>();
        r.material.DisableKeyword("_EMISSION");
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= 3.0f)
        {
            r = GetComponent<MeshRenderer>();

            r.material.EnableKeyword("_EMISSION");
        }
	}
}
