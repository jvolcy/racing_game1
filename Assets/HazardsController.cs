using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardsController : MonoBehaviour
{
    public float YRange = 50f;
    public GameManager gameManager;

    float XPos;

    // Start is called before the first frame update
    void Start()
    {
        ResetHazardPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7f)
        {
            ResetHazardPosition();
        }
        else
        {
            transform.position = new Vector2(XPos, transform.position.y - gameManager.Speed * Time.deltaTime);
        }

    }

    void ResetHazardPosition()
    {
        XPos = Random.Range(-5f, 5f);
        transform.position = new Vector2(XPos, Random.Range(7f, YRange));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name == "pothole")
        {
            //Debug.Log("pothole");
            gameManager.Speed -= 0.4f;
            if (gameManager.Speed < 0f) gameManager.Speed = 0f;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.name)

        if (gameObject.name == "oil")
        {
            //Debug.Log("oil");
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(gameManager.Speed * Random.Range(-5000f, 5000f) * Vector2.right);
            //rb.AddForce(1000000f * Vector2.right);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.name == "oil")
        {
            //Debug.Log("oil");
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;

            //rb.AddForce(1000000f * Vector2.right);
        }

    }
}
