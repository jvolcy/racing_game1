using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npCarController : MonoBehaviour
{
    public GameManager gameManager;

    float xPos = 0f;
    float Speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameOver) return;

        if (transform.position.y < -7f)
        {
            xPos = Random.Range(-5.0f, 5.0f);
            transform.position = new Vector2(xPos, 7f);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            Speed = 10f;
            gameManager.Score += gameManager.Speed * 5;
        }
        else if (transform.position.y > 7f)
        {
            xPos = Random.Range(-5.0f, 5.0f);
            transform.position = new Vector2(xPos, -7f);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            Speed = 10f;
        }
        else
        {
            transform.Translate(Vector3.up * (Speed - gameManager.Speed) * Time.deltaTime);
            //transform.position = new Vector3(xPos, transform.position.y + (Speed - gameManager.Speed)*Time.deltaTime);
        }

    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("X");
        Speed -= 0.2f;
        if (Speed < 0f) Speed = 0f;
    }

}
