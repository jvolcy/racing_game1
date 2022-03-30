using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector2(transform.position.x, transform.position.y - gameManager.Speed * Time.deltaTime);
     }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GameOver = true;
        gameManager.Speed = 0f;
    }
}
