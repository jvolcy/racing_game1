using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public float Speed = 0f;

    public GameObject FinishLine;
    public TMPro.TMP_Text SpeedText;
    public TMPro.TMP_Text ScoreText;
    public TMPro.TMP_Text PercentText;

    [HideInInspector]
    public bool GameOver = false;

    [HideInInspector]
    public float Score = 0f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        SpeedText.text = "Speed: " + (Speed * 5).ToString("###") + " MPH";
        ScoreText.text = "Score: " + ((int)Score).ToString("#####");
        PercentText.text = (int)(100f - FinishLine.transform.position.y / 10) + "% ";
    }


    public void IncreaseSpeed(float deltaSpeed)
    {
        if (GameOver == true)
        {
            Speed = 0f;
            return;
        }

        Speed += deltaSpeed;

        if (Speed < 0f) Speed = 0f;
        if (Speed > 25f) Speed = 25f;

    }
}
