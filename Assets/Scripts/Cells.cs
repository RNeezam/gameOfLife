using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cells : MonoBehaviour
{
    private SpriteRenderer sr;

    public Vector2 cellPosition = Vector2.zero;

    private bool alive;
    public bool tempAlive;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnMouseUp()
    {
        SetAlive(!alive);
    }

    public void SetAlive(bool value)
    {
        alive = value;

        if (alive)
        {
            sr.color = Color.black;
        }
        else
        {
            sr.color = Color.white;
        }
    }

    public bool Alive
    {
        get
        {
            return alive;
        }
    }
}
