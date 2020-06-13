using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraColliderTest : MonoBehaviour
{

    public GameObject arCam;
    public Text targetTxt, areaTxt;
    public RaycastHit oldObject;
    public bool firstCastBool = true;


    void Start()
    {

    }

    void Update()
    {

            RaycastHit hit;

            if (Physics.Raycast(arCam.transform.position, arCam.transform.forward, out hit))
            {

                if (hit.transform.tag == "Items")
                {
                    if (firstCastBool)
                    {
                        firstCastBool = false;
                        oldObject = hit;
                    }

                    oldObject = hit;

                }
                else
                {
                    oldObject = hit;
                }
            }
            else
            {
                oldObject = hit;
            }
    }

    public void InterctWithObject()
    {
        //checking = true;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Area1")
            areaTxt.text = "Area 1";
        else if (col.name == "Area2")
            areaTxt.text = "Area 2";
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Area1" || col.name == "Area2")
            areaTxt.text = "";
    }

}
