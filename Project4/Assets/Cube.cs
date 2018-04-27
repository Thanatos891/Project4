using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public CubeData cd;

    
    public int cubeLength;
    public int cubeWidth;
    public int cubeHeight;

    public GameObject cubeTest;
	// Use this for initialization
	void Start () {
       this.cd= Resources.Load<CubeData>("TestCube");
        cubeLength = cd.length;
        cubeWidth = cd.width;
        cubeHeight = cd.height;

        cubeTest.transform.localScale += new Vector3(cubeWidth, 0, cubeLength);
        

        
	}
    

}
