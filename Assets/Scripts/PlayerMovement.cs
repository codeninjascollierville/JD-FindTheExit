using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float verticle = Input.GetAxis("Verticle");
        Vector3 destination = new Vector3(horizontal, 0, verticle);
        transform.Translate(destination * speed * Time.deltaTime);
    }
}
