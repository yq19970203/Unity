using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kickBell : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bell;
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.CompareTag("lefthand") || other.gameObject.CompareTag("righthand"))
        {
            Destroy(bell);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
