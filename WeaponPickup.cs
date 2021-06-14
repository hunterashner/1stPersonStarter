using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public GameObject rocketLauncher;
    public bool unarmed = true;
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
            Debug.Log("...");
            Instantiate(rocketLauncher, rocketLauncher.transform.parent);
            unarmed = false;
        }
    }
}
