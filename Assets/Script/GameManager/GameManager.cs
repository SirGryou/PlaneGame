using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    public void Start()
    {
        score = GetComponent<Text>();
    }

    public void Update()
    {
        score.text = "Score" +scoreValue;
    }
}
