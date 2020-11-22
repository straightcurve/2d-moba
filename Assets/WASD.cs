using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public Vector2 speed = new Vector2(5f, 10f);
    private Rigidbody rb;

    void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var to = new Vector3();
        to.x = Input.GetAxis("Horizontal") * speed.x;
        to.z = Input.GetAxis("Vertical") * speed.y;

        if (to.magnitude < .1f)
            return;

        rb.position += to * Time.deltaTime;
    }
}
