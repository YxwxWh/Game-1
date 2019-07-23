using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
        float x = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0,x,0));
	}
}
