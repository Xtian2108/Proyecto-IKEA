using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesUiAr : MonoBehaviour
{

    public ObjectController objController;
    public Vector3 pos;
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(Camera.main.transform.position.x, transform.position.y, Camera.main.transform.position.z);
       transform.LookAt(targetPos);
        transform.position = pos;
    }
    public void CamvasUiForModels()
    {
        objController.currentModel.position = pos;
    }
}
