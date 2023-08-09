using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceSpawn : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        if (rb)
        {
            rb.AddRelativeForce(Vector3.up * 100, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
