using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    bool triggered;

    private void Start()
    {
        triggered = false;
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (!triggered)
        {
            if(collider.tag == "Player")
            {
                //thethingitshoulddo
                Debug.Log("Je suis dedans");
                triggered = true;
                GameManager.scoreValue += 10;
            }
        }
    }


    void OnGUI()
    {
        if (triggered)
        {
            GUI.Label(new Rect(50, 50, 200, 40), "PressSpace");
            Debug.Log("J'affiche un truc");
        }

    }
}
