using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(this.gameObject.name + "ENTERED trigger: ");
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log(this.gameObject.name + "STAYING in trigger: ");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(this.gameObject.name + "EXITED trigger: ");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
