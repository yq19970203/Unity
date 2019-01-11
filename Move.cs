using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update;
    Vector2 trackPose;
    Rigidbody rb;
    public float speed;
    Vector3 someFun(Vector2 v)
    {
        return new Vector3(v.x,0f,v.y);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        trackPose = GameObject.FindGameObjectWithTag("lefthand").GetComponent<handData>().getSpeed();
        //print("MoveTrackPose"+trackPose);
        Vector3 move = someFun(trackPose);
        //print("Move"+move);
        rb.velocity = speed * move;
    }
}
