using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class FaceStickerTest : MonoBehaviour
{
    public ARFaceManager arFaceScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetFaceSticker(int i)
    {
        foreach (ARFace face in arFaceScript.trackables)
        {
            if (i == 0)
            {
                face.transform.GetChild(0).gameObject.SetActive(true);
                face.transform.GetChild(1).gameObject.SetActive(false);
            }
            else if (i == 1)
            {
                face.transform.GetChild(1).gameObject.SetActive(true);
                face.transform.GetChild(0).gameObject.SetActive(false);
            }
        }
    }
}
