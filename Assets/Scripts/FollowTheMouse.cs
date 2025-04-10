using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class FollowTheMouse : MonoBehaviour
{
    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = mousPos;

        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            sr.color = Random.ColorHSV();
        }
    }
}
