using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    private BallCreator ballCreator;
    private int index = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        ballCreator = GetComponent<BallCreator>();
    }
    private void OnLevelWasLoaded(int level)
    {
        //svaki put kada se sceene ucita
        if (Application.loadedLevelName == "Gameplaye")
        {
            CreateBall();
        }
    }
    public void SetBallIndex(int index)
    {
        this.index = index;
    }
    public void CreateBall()
    {
        ballCreator.CreateBall(index);
    }
  
  
}
