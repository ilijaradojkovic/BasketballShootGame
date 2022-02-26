using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    [SerializeField] GameObject gameMan;
    private void Start()
    {
        gameMan = GameObject.Find("GameManager");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Destroy(collision.gameObject);
        gameMan.GetComponent<GameManagerScript>().CreateBall();
    }
}
