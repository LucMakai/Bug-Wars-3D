using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Vector3 direction = new Vector3(1, 0, 0);
    public float speed = 8;

    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, speed *Time.deltaTime, 0);
        velocity = direction * speed;
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;

        pos += velocity * Time.deltaTime;

        transform.position = pos;
    }
}
