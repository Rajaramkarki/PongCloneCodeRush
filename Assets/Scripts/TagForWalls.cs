using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tag
{
    leftWall,
    rightWall,
    leftRacket,
    rightRacket
}
public class TagForWalls : MonoBehaviour
{
    public Tag wallTag;
}
