using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * h * velocity * Time.deltaTime, Space.World);
        transform.Translate(Vector3.up * v * velocity * Time.deltaTime, Space.World);
    }
    
}
