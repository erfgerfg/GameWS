using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stolknovenie : MonoBehaviour
{
    private Rigidbody2D rb;
    public float tol = 10;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        rb.velocity = new Vector2(tol*2, tol*2);
    }
}
