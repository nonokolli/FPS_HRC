using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotDataInput : MonoBehaviour
{
    public OSC osc;
    public float robotPositionX;
    public float robotPositionY;
    public float robotPositionZ;
    public float robotRotationX;
    public float robotRotationY;
    public float robotRotationZ;
    public float robotSpeedX;
    public float robotSpeedY;
    public float robotSpeedZ;
    public float robotSpeedRotX;
    public float robotSpeedRotY;
    public float robotSpeedRotZ;


    // Start is called before the first frame update
    void Start()
    {
        osc.SetAddressHandler("/robotData", OnReceiveRobotData);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnReceiveRobotData(OscMessage message)
{

robotPositionX = message.GetFloat(0);
robotPositionY = message.GetFloat(1);
robotPositionZ = message.GetFloat(2);
robotRotationX = message.GetFloat(3);
robotRotationY = message.GetFloat(4);
robotRotationZ = message.GetFloat(5);
robotSpeedX = message.GetFloat(6);
robotSpeedY = message.GetFloat(7);
robotSpeedZ = message.GetFloat(8);
robotSpeedRotX = message.GetFloat(9);
robotSpeedRotY = message.GetFloat(10);
robotSpeedRotZ = message.GetFloat(11);





}





}
