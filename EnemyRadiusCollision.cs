using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRadiusCollision : MonoBehaviour
{
    public bool playerDetected = false;
    public GameObject playerPosition;
    public float enemySpeed = 10;
    public int enemyLife = 100;
    public int playerLife = 100;
    public float maxDist;
    public float minDist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerPosition.transform.position);

            if (Vector3.Distance(transform.position, playerPosition.transform.position) >= minDist)
            {
                transform.position += transform.forward * enemySpeed * Time.deltaTime;
            }

            if (Vector3.Distance(transform.position, playerPosition.transform.position) <= maxDist)
            {
                //temp placeholder for ranged attacks
            
            }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Enemy Detected");
            playerDetected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Enemy Left Detection Radius");
            playerDetected = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
            if (collision.collider.GetType() == typeof(CapsuleCollider) && collision.gameObject.name == "Player")
            {
                Debug.Log("Player Attack Detected");
                playerLife = playerLife - 36;
            }
    } */
    


}
