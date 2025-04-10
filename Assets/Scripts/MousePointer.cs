using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointer : MonoBehaviour
{
    public float speed = 2f;
    private void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector3 direction = mousePos - transform.position;

        transform.up = direction;

        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        pos += direction * speed * Time.deltaTime;

        transform.position = pos;
    }
}
