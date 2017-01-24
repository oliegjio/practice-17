using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleShutter
{
    public class WalkThroughWall : MonoBehaviour
    {
        private Color myColor = new Color(255, 0, 0, 0.5f);

        //private void OnEnable()
        //{
        //    gameObject.layer = LayerMask.NameToLayer("Not Solid");
        //}

        //private void OnDisable()
        //{
        //    gameObject.layer = LayerMask.NameToLayer("Default");
        //}

        public void SetLayerToNotSolid()
        {
            gameObject.layer = LayerMask.NameToLayer("Not Solid");
            GetComponent<Renderer>().material.color = myColor;
        }

        public void SetLayerToDefault()
        {
            gameObject.layer = LayerMask.NameToLayer("Default");
            GetComponent<Renderer>().material.color = Color.white;
        }

    }
}
