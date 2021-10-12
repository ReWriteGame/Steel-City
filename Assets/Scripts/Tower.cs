using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Tower : MonoBehaviour
{
    public UnityEvent getDamageEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>())
            getDamageEvent?.Invoke();
    }
}
