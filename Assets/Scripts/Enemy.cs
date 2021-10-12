using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Bullet>() || collision.gameObject.GetComponent<Tower>())
            gameObject.GetComponent<Destroyable>().Destroy();
    }
}
