using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARRaycastPlace : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject objectToPlace;
    private GameObject placedObject;

    public Camera arCamera;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    
    void Update() { 
        Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            
            if ( raycastManager.Raycast(ray, hits, TrackableType.Planes))
            {
                 Pose hitpose = hits[0].pose;
                if (placedObject == null) 
                {
                    placedObject = Instantiate(objectToPlace, hitpose.position, hitpose.rotation);
                }
                else
                {
                    placedObject.transform.position = hitpose.position;
                    placedObject.transform.rotation = hitpose.rotation;

                }
                
            }
        }
    }
}
