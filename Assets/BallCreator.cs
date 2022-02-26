using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private Sprite[] ballsImages;
    private float minX = -4.7f,maxX=4f,minY=-2.5f,maxY=1.5f;


    private void Start()
    {

        
    }
    public void CreateBall(int index)
    {
        if(ball==null) ball = GameObject.Find("Ball(Clone)");
        ball.GetComponent<ShootScript>().shoot = false;
        var gameObj= Instantiate(ball, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0f), Quaternion.identity);

        gameObj.GetComponent<SpriteRenderer>().sprite = ballsImages[index];
    }
}
