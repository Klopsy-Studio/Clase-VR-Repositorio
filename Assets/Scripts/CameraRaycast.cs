using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
        EventManager.OnClicked += ActivateRay;
    }


    void ActivateRay()
    {
        Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo ))
        {

            if (hitInfo.collider.TryGetComponent(out Role target))
            {
                Debug.Log("el objetivo es " + target.objectId);
            }
            else
            {
                Debug.Log("no entra aqui");
            }
        }
    }
}
