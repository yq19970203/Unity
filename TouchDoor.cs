using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDoor : MonoBehaviour
{
    private Animator openDoor;
    public GameObject door;

    private void Start()
    {
        openDoor = this.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hand"))
        {
            openDoor.SetTrigger("open");
            Destroy(door, 2.0f);
        }
    }
}
