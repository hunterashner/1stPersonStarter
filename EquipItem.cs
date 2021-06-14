using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    GameObject rocketLauncher;
    GameObject spawnLocation;
    //Vector3 gunPosition = spawnLocation.transform.position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PickUp")
        {
           // Instantiate(rocketLauncher, gunPosition);
        }
    }
}
