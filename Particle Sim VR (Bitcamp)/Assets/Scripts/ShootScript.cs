using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ShootScript : MonoBehaviour {

    public GameObject projectilePrefab;
    public float speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        var joystickNames = Input.GetJoystickNames();

        if (Input.GetButtonDown("Fire") || Input.GetButtonDown("Jump")) {
            // Shoot stuff
            var projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity) as GameObject;
            var projBody = projectile.GetComponent<Rigidbody>();
            projBody.velocity = transform.forward * speed;
        }
	}
}
