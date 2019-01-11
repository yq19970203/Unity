using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordMove11 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform start;
    public Transform end;
    public GameObject word;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Bell11.wordM == true)
        {
            transform.position = Vector3.MoveTowards(start.position, end.position, speed * Time.deltaTime);
            Destroy(word, 4.0f);
        }
    }
}
