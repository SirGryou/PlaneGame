using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Follow : MonoBehaviour
{
    public Transform target;
    public float distance;

    void Update()
    {
        transform.position = target.position - new Vector3(0, 0, distance);
    }

}
