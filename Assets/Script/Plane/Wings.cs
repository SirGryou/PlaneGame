using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wings : MonoBehaviour
{
    public Rigidbody plane;

    public float lift = 1f;

    public bool debug = false;

    void FixedUpdate()
    {
        Vector3 velocity = plane.GetPointVelocity(transform.position);
        float speed = velocity.magnitude;
        Vector3 direction = velocity.normalized;
        Vector3 worldNrm = transform.up;
        if (Vector3.Dot(worldNrm, direction) < 0)
            worldNrm = -worldNrm;
        float angle = 1f - Mathf.Clamp((Vector3.Angle(worldNrm, direction) / 90f), 0, 1f);
        Vector3 drag = -worldNrm * angle * speed * speed * lift;

        if(debug)
        {
            Debug.DrawRay(transform.position, drag, Color.green);
            Debug.Log(angle);
        }
        plane.AddForceAtPosition(drag * Time.fixedDeltaTime, transform.position);
    }

}
