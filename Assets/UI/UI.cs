using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

    private int UIState = 0;

    private static GameObject DialogueStartUI;  //UIState = 0;
    private static GameObject GameUI;           //UIState = 1;
    private static GameObject PauseUI;          //UIState = 2;
    private static GameObject DeathUI;          //UIState = 3;
    private static GameObject DialogueEndUI;    //UIState = 4;

    public static void SetState(int state)
    {
        switch (state)
        {
            case 0:
                DialogueStartUI.SetActive(true);
                GameUI.SetActive(false);
                PauseUI.SetActive(false);
                DeathUI.SetActive(false);
                DialogueEndUI.SetActive(false);
                break;
            case 1:
                DialogueStartUI.SetActive(false);
                GameUI.SetActive(true);
                PauseUI.SetActive(false);
                DeathUI.SetActive(false);
                DialogueEndUI.SetActive(false);
                break;
            case 2:
                DialogueStartUI.SetActive(false);
                GameUI.SetActive(false);
                PauseUI.SetActive(true);
                DeathUI.SetActive(false);
                DialogueEndUI.SetActive(false);
                break;
            case 3:
                DialogueStartUI.SetActive(false);
                GameUI.SetActive(false);
                PauseUI.SetActive(false);
                DeathUI.SetActive(true);
                DialogueEndUI.SetActive(false);
                break;
            case 4:
                DialogueStartUI.SetActive(false);
                GameUI.SetActive(false);
                PauseUI.SetActive(false);
                DeathUI.SetActive(false);
                DialogueEndUI.SetActive(true);
                break;
        }
    }

    void Start()
    {
        DialogueStartUI = GameObject.Find("DialogueStart");
        GameUI = GameObject.Find("Game");
        PauseUI = GameObject.Find("Pause");
        DeathUI = GameObject.Find("Death");
        DialogueEndUI = GameObject.Find("DialogueEnd");
        SetState(0);
    }

    void Update()
    {
        
    }
}
