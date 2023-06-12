using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newRotation = cam.transform.eulerAngles;
    newRotation.x = 0;
    newRotation.z = 0;
    transform.eulerAngles = newRotation;
    }
}
