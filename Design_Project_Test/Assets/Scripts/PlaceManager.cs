using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;

public class PlaceManager : MonoBehaviour
{
    private PlaceIndicator placeIndicator;
    public GameObject objectToPlace;

    private GameObject newPlacedObject;
    
    
    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();

    }

    
   public void ClickForPlace()
    {

        
        if (newPlacedObject == null)
        {
            newPlacedObject = Instantiate(objectToPlace,
            placeIndicator.transform.position, placeIndicator.transform.rotation);
        }
        else 
        {
            
            newPlacedObject.transform.position = placeIndicator.transform.position;
            newPlacedObject.transform.rotation = placeIndicator.transform.rotation;
        }
       // newPlacedObject = Instantiate(objectToPlace, 
         //   placeIndicator.transform.position, placeIndicator.transform.rotation);

    }
    public void ClickForRotateRight() 
    {
        newPlacedObject.transform.Rotate(Vector3.up, 10f);
    }

    public void ClickForRotateLeft()
    {
        newPlacedObject.transform.Rotate(Vector3.up, -10f);
    }

}
