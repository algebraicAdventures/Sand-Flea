using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    Slider jumpPower;

	// Use this for initialization
	void Start () {
        jumpPower = transform.Find("JumpPower").gameObject.GetComponent <Slider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateJumpPower(float value)
    {
        jumpPower.value = value;
    }
}
