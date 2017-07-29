using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLogic : MonoBehaviour {

    public GameObject followObject;
    public Vector3 followPosition;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        updatePosition();
	}

    void updatePosition()
    {
        transform.position = followObject.transform.position + followPosition;
    }
}
