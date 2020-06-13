using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    Transform target;
    float damping = 2f;
    bool startFace = false;

    // Use this for initialization
    void Start()
    {
        //yield return new WaitForSeconds(0.5f);
        target = Camera.main.transform;
        startFace = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (startFace)
        {
            var lookPos = target.position - transform.position;
            lookPos.y = 0;

            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        }
    }

    private void OnEnable()
    {
        //this.GetComponent<CanvasGroup>().alpha = 0;
        //LeanTween.alphaCanvas(this.GetComponent<CanvasGroup>(), 1f, 1f);
    }
}
