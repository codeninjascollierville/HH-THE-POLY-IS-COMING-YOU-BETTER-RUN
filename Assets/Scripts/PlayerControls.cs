using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

[Header("default qajumpisgn sapoewr")]
public float jumpPower = 6f;

[Header("bovoldea n isd goru8nde")]
public bool isGrounded = false;

float posX = 0.0f;

Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

rb = transform.GetComponent<Rigidbody2D>();

posX = transform.position.x;










    }

    // Update is called once per frame
    void Update()
    {

    }
}
