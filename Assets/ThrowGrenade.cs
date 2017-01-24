using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleShutter
{
    public class ThrowGrenade : MonoBehaviour
    {
        public float fireRate = 0.5f;
        private float lastShot;
        public float propultionForce = 5;
        public GameObject grenadePrefab;
        Transform myTransform;

        // Use this for initialization
        void Start()
        {
            SetInitialReferences();
        }

        // Update is called once per frame
        void Update()
        {
            if (Time.time > lastShot + fireRate && Input.GetKey(KeyCode.Mouse0))
            {
                lastShot = Time.time;
                SpawnGrenade();
            }
        }

        void SetInitialReferences()
        {
            myTransform = transform;
        }

        void SpawnGrenade()
        {
            GameObject grenade = (GameObject) Instantiate(grenadePrefab, myTransform.TransformPoint(0, 0, 0.5f), myTransform.rotation);
            grenade.GetComponent<Rigidbody>().AddForce(myTransform.forward * propultionForce, ForceMode.Impulse);
            Destroy(grenade, 10);
        }
    }
}
