using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSelectScript : MonoBehaviour
{
    private List<Button> buttons = new List<Button>();
    void Start()
    {
        GetButtonsAndAddListeners();
    }

    void GetButtonsAndAddListeners()
    {
        GameObject[] btns = GameObject.FindGameObjectsWithTag("ball");
        for (int i = 0; i < btns.Length; i++)
        {
            buttons.Add(btns[i].GetComponent<Button>());
            buttons[i].onClick.AddListener(SelectABall);
        }
    }
    public void SelectABall()
    {
        int index = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        if (GameManagerScript.instance != null)
        {
            GameManagerScript.instance.SetBallIndex(index);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
