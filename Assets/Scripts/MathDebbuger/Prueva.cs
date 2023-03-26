using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueva : MonoBehaviour
{
    Vector3 a = new Vector3(2, 2, 3);
    Vector3 b = new Vector3(1, 1, 3);

    public void SetVec3(float newX, float newY, float newZ)
    {
        new Vector3(newX, newY, newZ);
    }

    // Update is called once per frame
    void Update()
    {
        print(Vector3.Scale(a,b));
    }
}
