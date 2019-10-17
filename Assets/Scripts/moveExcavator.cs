using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveExcavator : MonoBehaviour
{
    int speed = 10;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") *  speed * Time.deltaTime, 0f);
    }
}
