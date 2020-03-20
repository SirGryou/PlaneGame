using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    bool onWrongGround;
    bool onObjectif;

    private void Start()
    {
        onWrongGround = false;
        onObjectif = false;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Objectif")
        {
            onWrongGround = false;
            onObjectif = true;
            if(onObjectif == true)
            {

            }
        }
    }
}
