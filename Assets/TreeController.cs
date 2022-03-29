using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -15)
        {
            transform.position = new Vector2(transform.position.x, 15);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - gameManager.Speed*Time.deltaTime);
        }

    }
}
