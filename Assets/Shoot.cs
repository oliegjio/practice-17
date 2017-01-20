using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float fireRate = 0.5f;
    float lastShoot = 0;
    RaycastHit hit;
    float range = 300;
    Transform myTransform;

	// Use this for initialization
	void Start () {
        SetInitialReferences();
	}
	
	// Update is called once per frame
	void Update () {
        CheckForInput();
	}

    void SetInitialReferences()
    {
        myTransform = transform;
    }

    void CheckForInput()
    {
        if(Input.GetKey(KeyCode.Mouse0) && lastShoot + fireRate < Time.time)
        {
            lastShoot = Time.time;
            Debug.DrawRay(myTransform.position, myTransform.forward, Color.red, 3);
            if(Physics.Raycast(myTransform.position, myTransform.forward, out hit, range) && hit.transform.CompareTag("Enemy"))
            {
                Debug.Log("Hit: " + hit.transform.name);
            }
        }
    }
}
