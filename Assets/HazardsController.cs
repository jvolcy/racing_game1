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
}
