using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    [SerializeField]
    private int moveSpeed = 2000;

    private Vector2 vecVelocity = Vector2.zero;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void MovePlayer()
    {
        vecVelocity.x = (Input.GetAxis("Horizontal") * Time.deltaTime);
        vecVelocity.y = (Input.GetAxis("Vertical") * Time.deltaTime);
        vecVelocity *= moveSpeed;
        rigidBody.velocity = vecVelocity;
    }

    void Update()
    {
        MovePlayer();
    }
}
