using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Vector3 enemyMoveDirector;
    public float moveDistance;

    private Vector3 startPosition;
    private bool movingToStart;

    void Start()
    {
        startPosition = transform.position;
    }

    
    void Update()
    {
        if(movingToStart)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, speed * Time.deltaTime);

            if(transform.position == startPosition)
            {
                movingToStart = false;
            }
   
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition + enemyMoveDirector * moveDistance, speed * Time.deltaTime);
            if (transform.position == startPosition + (enemyMoveDirector * moveDistance))
            {
                movingToStart = true;
            }
        }
    }
}
