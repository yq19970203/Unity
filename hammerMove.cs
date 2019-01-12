using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform start;
    public Transform end;
    public Transform hand;
    public float speed;
    public float finalSpeed;
    public static bool anim_play = false;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("lefthand"))
        {
            anim.SetBool("Move",true);
            anim_play = true;
        }
    }


    void Update()
    {
        if (anim_play == true && Bell4.finalMove == false)
        {
            transform.position = Vector3.MoveTowards(start.position, end.position, speed * Time.deltaTime);
        }
        if (anim_play == true && Bell4.finalMove == true)
        {
            anim.SetBool("Move", false);
            transform.position = Vector3.MoveTowards(start.position, hand.position, finalSpeed * Time.deltaTime);
        }
    }

}
