using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningScript : MonoBehaviour {

    //attribute Range is used to set the Range for the speed of the cube
    //to -50 and 50, with 0 being the middle. 
    [Range(-50,50)]
    public int spinSpeed = 0;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, spinSpeed * Time.deltaTime, 0));
	}
}
