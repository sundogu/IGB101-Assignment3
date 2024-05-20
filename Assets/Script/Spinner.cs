using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float rotateAngle = .2f;

    void Update()
    {
        transform.Rotate(0, rotateAngle, 0, Space.Self);
    }
}
