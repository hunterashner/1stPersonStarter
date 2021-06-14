using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimPairing : MonoBehaviour
{
    
    public GameObject cameraAim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aimPairer();
    }

    void aimPairer()
    {
        this.transform.rotation = cameraAim.transform.rotation;
    }
}
