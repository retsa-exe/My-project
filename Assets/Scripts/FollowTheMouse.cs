using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class FollowTheMouse : MonoBehaviour
{
    private void Update()
    {
        //Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = mousPos;

        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
