using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;

    float xPos = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dX = 0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dX = 0.1f;
            transform.rotation = Quaternion.Euler(0f, 0f, -5f);
            transform.Translate(new Vector3(dX, 0f, 0f),Space.World);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dX = -0.1f;
            transform.rotation = Quaternion.Euler(0f, 0f, 5f);
            transform.Translate(new Vector3(dX, 0f, 0f),Space.World);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow)) gameManager.Speed += 0.001f;
        if (Input.GetKey(KeyCode.DownArrow)) gameManager.Speed -= 0.001f;

        if (gameManager.Speed < 0f) gameManager.Speed = 0f;
        if (gameManager.Speed > .5f) gameManager.Speed = .5f;

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("X");
        gameManager.Speed -= 0.002f;
        if (gameManager.Speed < 0f) gameManager.Speed = 0f;
    }

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Y");

        //gameManager.Speed -= 0.01f;
        //if (gameManager.Speed < 0f) gameManager.Speed = 0f;

    }
    */
    
}