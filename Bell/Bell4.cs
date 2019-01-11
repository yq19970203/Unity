using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell4 : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    AudioSource sound;
    public static bool wordM = false;
    public static bool finalMove = false;
    void Start()
    {
        anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hammer"))
        {
            anim.SetBool("swing",true);
            wordM = true;
            finalMove = true;
            sound.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("hammer"))
        {
            anim.SetBool("swing", false);
        }
    }

}
