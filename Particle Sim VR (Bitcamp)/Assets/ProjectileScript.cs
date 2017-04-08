using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

    private Rigidbody rigidbody;
    public float speed;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();

        var angle = rigidbody.rotation;
        var r = speed;

	}
	
	// Update is called once per frame
	void Update () {
	}
}
