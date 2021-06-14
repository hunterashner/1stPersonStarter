using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    public GameObject projectile;
    public GameObject spawnLocation;
    private Vector3 projectileSpawn;
    public GameObject spawnOrientation;
    private Quaternion spawnPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            spawnPosition = spawnOrientation.transform.rotation;
            projectileSpawn = spawnLocation.transform.position;
            Instantiate(projectile, projectileSpawn, spawnPosition);
            projectile.transform.parent = null;
        }
    }
}
