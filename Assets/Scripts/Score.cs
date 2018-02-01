using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    Text textComp;
    int points;
    Animator anim;

    public int Points
    {
        get
        {
            return points;
        }

        set
        {
            points += value;
            textComp.text = "Score: " +  points + " pts";
            anim.SetTrigger("AddPoints");
        }
    }

    void Awake()
    {
        textComp = GetComponent<Text>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        textComp.text = "Score: 0 pts";
    }


}
