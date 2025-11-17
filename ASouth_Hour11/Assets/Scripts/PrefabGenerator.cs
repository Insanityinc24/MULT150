using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)

        {
            // Each lamp is spaced 2 units apart along the X-axis
            Vector3 spawnPosition = transform.position + new Vector3(i * 2.0f, 0, 0);
            Instantiate(prefab, spawnPosition, transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
     // Whenever we hit the B key will generate a prefab at the
     // position of the original prefab
     // When ever we hit the space key, we will generate a prefab at the
     // position of the spawn on=bject that this script is attached to
     if (Input.GetKeyDown(KeyCode.B))
     {
       Instantiate(prefab);
     }
     if (Input.GetKeyDown(KeyCode.Space))
     {
       Instantiate(prefab, transform.position, transform.rotation);
     }
    }
}
