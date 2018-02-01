using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    Button btnPlay;
    [SerializeField]
    Button btnQuit;

    void Awake()
    {
        btnPlay.onClick.AddListener(Play);
        btnQuit.onClick.AddListener(Quit);
    }

    void Play()
    {
        SceneManager.LoadScene(1);
    }

    void Quit()
    {
        //Quit action
        Application.Quit();
    }
}
