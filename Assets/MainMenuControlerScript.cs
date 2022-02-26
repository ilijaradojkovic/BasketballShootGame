using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuControlerScript : MonoBehaviour
{
    private Animator mainAnim, ballAnim;
    // Start is called before the first frame update
    private void Awake()
    {
        mainAnim = GameObject.Find("MainHolder").GetComponent<Animator>();
        ballAnim = GameObject.Find(" BallsHolder").GetComponent<Animator>();
    }
    public void PlayGame()
    {
        Application.LoadLevel("Gameplaye");
    }
    public void SelectBall()
    {
        mainAnim.Play("FadeOut");
        ballAnim.Play("FadeInBalls");
    }
    public void BackToMenu()
    {
        mainAnim.Play("FadeIn");
        ballAnim.Play("FadeOutBalls");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
