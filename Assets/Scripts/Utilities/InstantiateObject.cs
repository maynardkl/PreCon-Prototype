using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.Experimental.XR;


[RequireComponent(typeof(ARRaycastManager))]
public class InstantiateObject : MonoBehaviour
{
    public GameObject gameObjectToInstantiate,
        placementIndicator, startButton, crossHair;


    private GameObject spawnedObject;
    private ARRaycastManager raycastManager;
    private Pose placementPose;
    private bool placementPoseIsValid = false;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();


    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {

        UpdatePlacementPose();
        UpdatePlacementIndicator();


    }

    private void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        if (raycastManager.Raycast(screenCenter, hits, trackableTypes: TrackableType.Planes))
        {
            placementPoseIsValid = hits.Count > 0;

            if (placementPoseIsValid)
            {
                placementPose = hits[0].pose;

                var cameraForward = Camera.current.transform.forward;
                var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
                placementPose.rotation = Quaternion.LookRotation(cameraBearing);


            }
        }
    }



    private void UpdatePlacementIndicator()
    {
        if (spawnedObject == null)
        {
            if (placementPoseIsValid)
            {
                placementIndicator.SetActive(true);
                startButton.SetActive(true);
                placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
            }
            else
            {
                placementIndicator.SetActive(false);
            }
        }
        else
        {
            placementIndicator.SetActive(false);
        }

    }

    public void PlaceObject()
    {
        if (placementPoseIsValid)
        {
            if (spawnedObject == null)
            {
                spawnedObject = Instantiate(gameObjectToInstantiate, placementPose.position, placementPose.rotation);
                spawnedObject.name = "EnvironmentObjects";
                crossHair.SetActive(true);
                startButton.SetActive(false);
                
            }
            else
            {
                //spawnedObject.transform.position = placementPose.position;
            }
        }

    }

    public void resetObject()
    {
        Destroy(spawnedObject.gameObject);
        spawnedObject = null;
        startButton.SetActive(true);
        crossHair.SetActive(false);
    }
}
