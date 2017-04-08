using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ShootScript : MonoBehaviour {

    public GameObject projectile;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        var joystickNames = Input.GetJoystickNames();

        if (joystickNames.Contains("Oculus Remote") && Input.GetAxisRaw("Fire") == 1) {
            // Shoot stuff
            Instantiate(projectile, gameObject.transform);
        }
	}
}
