using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject model;
    public GameObject hammer;
    public GameObject hammer_final;
    public static bool changeModel = false;
    void Start()
    {
        model.SetActive(true);
        hammer_final.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hammer"))
        {
            changeModel = true;
            Destroy(hammer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (changeModel == true)
        {
            model.SetActive(false);
            hammer_final.SetActive(true);
        }
    }
}
