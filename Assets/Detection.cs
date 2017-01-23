using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleShutter
{
    public class Detection : MonoBehaviour
    {

        RaycastHit hit;
        [SerializeField] private LayerMask detectionLayer;
        float checkRate = 0.5f;
        float nextCheck;
        float range = 50;
        Transform myTransform;

        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            DetectItems();
        }

        void SetInitialReferences()
        {
            detectionLayer = 1 << 9;
            myTransform = transform;
        }

        void DetectItems()
        {
            if(Time.time > nextCheck)
            {
                nextCheck = Time.time + checkRate;
                if(Physics.Raycast(myTransform.position, myTransform.forward, out hit, range, detectionLayer))
                {
                    Debug.Log(hit.transform.name + " is an " + detectionLayer.value);
                }
            }
        }
    }
}
