using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBox : MonoBehaviour
{
    public GameObject box;

    private void Update()
    {
        if(Input.GetKey("espace"))
        {
            Instantiate(box, transform.position, transform.rotation);
        }
    }
}
