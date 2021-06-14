using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileCollision : MonoBehaviour
{
    //public GameObject explosion;
    public Rigidbody rb;
    public float projectileSpeed;
    public Transform aimingDirection;
    public AudioSource rocketFireSound;
    public int power = 10;
    public float radius = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rocketFireSound = GetComponent<AudioSource>();
        aimingDirection = GameObject.Find("Player").transform;
        rocketFireSound.Play(0);
        Debug.Log("sound started");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("projectile collision detected");
        rocketFireSound.Pause();
        //Instantiate(explosion, this.transform);
        //rb.AddExplosionForce(power, this.transform.position, radius, 3.0f);
        Destroy(this.gameObject);
    }
}
