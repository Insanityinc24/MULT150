using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Horizontal") / 1;
        float mY = Input.GetAxis("Vertical") / 1;
        Vector3 movement = new Vector3(mX, mY, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
