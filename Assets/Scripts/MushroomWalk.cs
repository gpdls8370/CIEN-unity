using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomWalk : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-0.01f * speed, 0, 0, Space.World);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, 0.01f * speed, Space.World);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(0.01f * speed, 0, 0, Space.World);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, -0.01f * speed, Space.World);


        if (Input.GetKey(KeyCode.Space))
            transform.Translate(0, 0.2f, 0, Space.World);
    }
}
