using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane : MonoBehaviour
{
    #region Transform
    public Transform wings;
    public Transform leftRudder;
    public Transform rightRudder;
    #endregion
    #region GameObject
    public GameObject rudder;
    #endregion
    #region float
    public float rudderRange = 10f;
    public float verticalRange = 10f;
    public float rotationSpeed = 90f;
    #endregion
    #region bool
    public bool invertControl = false;
    #endregion
    #region Vector3
    private Vector3 wingsStartRot = Vector3.zero;
    private Vector3 leftRudderStartRot = Vector3.zero;
    private Vector3 rightRudderStartRot = Vector3.zero;
    #endregion

    void Start()
    {
        leftRudderStartRot = leftRudder.localEulerAngles;
        wingsStartRot = wings.localEulerAngles;
        rightRudderStartRot = rightRudder.localEulerAngles;
    }

    void Update()
    {
        #region Dedbug
        //ForDebug
        if (Input.GetKeyDown(KeyCode.R))
        {
            rudder.SetActive(!rudder.activeSelf);
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        #endregion

        #region control
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal") * rudderRange, 0, 0);
        Vector3 vertical = new Vector3(Input.GetAxis("Vertical") * verticalRange, 0, 0);

        if(invertControl)
        {
            horizontal = -horizontal;
            vertical = -vertical;
        }
        leftRudder.localEulerAngles = leftRudderStartRot - horizontal;
        rightRudder.localEulerAngles = rightRudderStartRot + horizontal;
        wings.localEulerAngles = wingsStartRot - vertical;
        #endregion
    }

}
