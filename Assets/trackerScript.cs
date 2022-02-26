using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class trackerScript : MonoBehaviour
{
    [SerializeField] Text textScore;
    [SerializeField] int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        score++;
        textScore.text = score.ToString();
    }
   
}
