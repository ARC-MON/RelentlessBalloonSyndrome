using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float speed = 0.5f;
    Vector3 StartPosition;
    private SpriteRenderer Renderer;
    void Start()
    {
        StartPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    public void OnBecameInvisible()
    {
        transform.position = StartPosition;
    }
}
