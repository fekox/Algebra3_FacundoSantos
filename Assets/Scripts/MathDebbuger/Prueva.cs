using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueva : MonoBehaviour
{
    Vector3 vector = new Vector3();

    Vector3 a = new Vector3(0, 2, 1);
    Vector3 b = new Vector3(1, 1, 3);


    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3();

        if (a.x < b.x) vector.x = a.x;
        else vector.x = b.x;

        if (a.y < b.y) vector.y = a.y;
        else vector.y = b.y;

        if (a.z < b.z) vector.z = a.z;
        else vector.z = b.z;

        print("Max: " + vector);
    }
}
