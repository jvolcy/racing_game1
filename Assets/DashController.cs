using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashController : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6.5)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 3*5f);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - gameManager.Speed);
        }

    }
}
