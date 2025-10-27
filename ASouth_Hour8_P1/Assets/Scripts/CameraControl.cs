using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        transform.Translate(moveX, moveY, 0f);
    }
}
