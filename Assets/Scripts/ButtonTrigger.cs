using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public PlayerMove player;
    void OnTriggerEnter2D(Collider2D obj)
    {
        player.currHealth -= 5f;
        Destroy(gameObject);
    }
}
