using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleShutter
{
    public class TriggerExample : MonoBehaviour
    {
        private WalkThroughWall walkThroughWallScript;

        private void OnTriggerEnter(Collider other)
        {
            walkThroughWallScript.SetLayerToNotSolid();
        }

        private void OnTriggerExit(Collider other)
        {
            walkThroughWallScript.SetLayerToDefault();
        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log("Object " + other.name + " stay on the trigger!");
        }

        private void SetInitialReferences()
        {
            if(GameObject.Find("TheWall"))
            {
                walkThroughWallScript = GameObject.Find("TheWall").GetComponent<WalkThroughWall>();
            }
        }

        void Start()
        {
            SetInitialReferences();
        }
    }
}
