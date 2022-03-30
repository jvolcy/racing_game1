using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    AudioSource audioSource;
    public AudioClip CrashClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameOver) return;

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

        if (Input.GetKey(KeyCode.UpArrow)) gameManager.IncreaseSpeed(0.1f);
        if (Input.GetKey(KeyCode.DownArrow)) gameManager.IncreaseSpeed(-0.1f);

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("X");
        gameManager.IncreaseSpeed(-0.2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "npCar")
        {
            audioSource.clip = CrashClip;
            audioSource.Play();
            gameManager.Score -= 100f;
        }
    }

}
