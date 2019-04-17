using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EzRotate : MonoBehaviour, IDragHandler
{

    float rotationSpeed = 2f;

    void OnMouseDrag()
    {
        
    }


    public void OnDrag(PointerEventData eventData)
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        // select the axis by which you want to rotate the GameObject
        transform.Rotate(Vector3.down, XaxisRotation);
    }
}

