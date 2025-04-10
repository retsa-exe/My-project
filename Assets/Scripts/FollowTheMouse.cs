using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheMouse : MonoBehaviour
{
    SpriteRenderer sr;

    public GameObject prefab;

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

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
