using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class targetMove : MonoBehaviour
{

    public GameObject robotData;
    robotDataInput targetPos;

    private float posX, posY, posZ;

    // Start is called before the first frame update
    void Start()
    {

        targetPos = robotData.GetComponent<robotDataInput>();


    }

    // Update is called once per frame
    void Update()
    {

        posX = targetPos.robotPositionX / 200;
        posY = targetPos.robotPositionY / 200;
        posZ = targetPos.robotPositionZ / 200;

        Debug.Log("The object position is (" + posX + "," + posY + "," + posZ + ")");


        transform.localPosition = new Vector3(posX, posY, posZ);

    }
}