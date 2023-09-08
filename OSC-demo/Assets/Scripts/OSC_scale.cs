using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class OSC_scale : MonoBehaviour
{ 

    public string xAddress = "/address";
    public OSCReceiver reveiver;

    private float cubeScale; 

    void Start()
    {
        reveiver.Bind(xAddress, ReceiveMessage);
    }

    private void ReceiveMessage(OSCMessage message)
    {
        cubeScale = message.Values[0].FloatValue;
        transform.localScale = new Vector3(cubeScale,cubeScale,cubeScale);
        //print(message);
    }

}
