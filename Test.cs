using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Test: MonoBehaviour
{
    SteamVR_Behaviour_Pose trackobj;

    public GameObject cube;

    // Start is called before the first frame update
    private void Start()
    {
        trackobj = GetComponent<SteamVR_Behaviour_Pose>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(trackobj.inputSource))
        {
            Destroy(cube);
        }
    }
}
