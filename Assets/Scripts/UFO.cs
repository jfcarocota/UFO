using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using OurGameLibrary.Character;

public class UFO : Controller
{

    [SerializeField, Range(0, 10)]
    float moveSpeed;
    bool isPickUp;
    Coin coin;

    private void Update()
    {
        transform.Translate(Axis(moveSpeed));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        isPickUp = collision.CompareTag("PickUp");
        if (isPickUp)
        {
            coin = collision.GetComponent<Coin>();
            GameManager.instance.Score.Points = coin.Points;
            GameManager.instance.PlayAudioClip(0);
            Destroy(collision.gameObject);
        }
    }
}
