using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Speed = 0f;
    public TMPro.TMP_Text SpeedText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpeedText.text = "Speed: " + (Speed * 400).ToString("###.0") + " MPH";
    }
}
