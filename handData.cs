using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class handData : MonoBehaviour
{
    Hand hand;
    private float moveHorizontal;
    private float moveVertical;

    // Start is called before the first frame update
    void Start()
    {
        hand = this.GetComponent<Hand>();
    }
    public Vector2 trackPose
    {
        get
        {
            return SteamVR_Input._default.inActions.touchpadPose.GetAxis(hand.handType);
        }
    }

    public Vector2 getSpeed()
    {
        moveVertical = Input.GetAxis("Vertical");
        moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        return movement;
    }

    private void Update()
    {
        Debug.Log(trackPose);
    }
}
