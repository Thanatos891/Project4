using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cube", menuName = "Cube")]
public class CubeData : ScriptableObject
{
    public new string name;
    [Range(0,100)]
    public int length = 0;
    [Range(0,100)]
    public int width = 0;
    [Range(0, 100)]
    public int height = 0;

    public GameObject spawnCube;
}
