using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherPickup : MonoBehaviour
{
    public GameObject launcher;
    public GameObject weaponSpawn;
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
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Collision Enter");
            Destroy(this.gameObject);
            Instantiate(launcher, weaponSpawn.transform, false);
        }
    }
}
