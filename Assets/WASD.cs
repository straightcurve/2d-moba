using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;

    void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var to = new Vector3();
        to.x = Input.GetAxis("Horizontal");
        to.z = Input.GetAxis("Vertical");

        rb.MovePosition(transform.position + to * speed * Time.deltaTime);
    }
}
