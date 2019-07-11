using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTeleportMachineScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector3(transform.position.x, transform.position.y + Mathf.PingPong(Time.deltaTime, 0.05f), transform.position.z);
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime*0.5f, Space.World);
    }
}
