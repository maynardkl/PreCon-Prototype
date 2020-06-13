using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public bool activateBool = false, disactivateBool = true;

    private CameraColliderTest raycastScript;
    // Start is called before the first frame update
    void Start()
    {
        raycastScript = GameObject.Find("AR Camera").GetComponent<CameraColliderTest>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!raycastScript.firstCastBool)
        {
            
            if (raycastScript.oldObject.transform == this.transform)
            {
                if (!activateBool)
                {
                    activateBool = true;
                    disactivateBool = false;
                    ActivateInfo();
                }
            }
            else
            {
                if (!disactivateBool)
                {
                    activateBool = false;
                    disactivateBool = true;
                    DisctivateInfo();
                }
            }
        }
    }

    private void ActivateInfo()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
    }
    private void DisctivateInfo()
    {
        this.transform.GetChild(0).gameObject.SetActive(true);
        this.transform.GetChild(0).gameObject.SetActive(false);
    }
}
