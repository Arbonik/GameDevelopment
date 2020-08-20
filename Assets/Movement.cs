using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 10;

    Rigidbody rigidbody;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        move.Set(horizontal, 0f, vertical);
        rigidbody.MovePosition(rigidbody.position + move * speed * Time.deltaTime);
    }
}
