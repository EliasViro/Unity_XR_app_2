using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public Vector3 rotateSpeedVec;

    void Update()
    {
        transform.Rotate(rotateSpeedVec * Time.deltaTime);
    }
}
