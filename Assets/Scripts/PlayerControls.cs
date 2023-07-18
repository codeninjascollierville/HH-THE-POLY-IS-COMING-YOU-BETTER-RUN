using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

[Header("default qajumpisgn sapoewr💀💀💀💀💀")]
public float jumpPower = 6f;

[Header("bovoldea n isd goru8nde💀💀💀💀")]
public bool isGrounded = false;

float posX = 0.0f;

Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

rb = transform.GetComponent<Rigidbody2D>();

posX = transform.position.x;


    }





void FixedUpdate()
{

if (Input.GetKey(KeyCode.Space) && isGrounded)
{
rb.AddForce(Vector3.up * (jumpPower * rb.mass * rb.gravityScale * 20.0f));


}

    if(transform.position.x < posX){

        GameOver();
    }









}









    

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {

if (collision.collider.tag == "Ground")
{
isGrounded = true;


}

if(collision.collider.tag == "Enemy"){

GameOver();

}




}

void OnTriggerEnter2D(Collider2D collision){

if(collision.tag == "Coin")
{


    GameObject.Find("GameController").GetComponent<GameController>().IncrementScore();




Destroy(collision.gameObject);

}





}


    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGrounded = true;
        }
    }



    void OnCollisionExit2D(Collision2D collision)
    {

if(collision.collider.tag == "Ground")
{
isGrounded = false;

}


        
    }






void GameOver()
{

GameObject.Find("GameController").GetComponent<GameController>().GameOver();















}



}

