using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GADVDataTypes
{
    public class TestScript : MonoBehaviour
    {
        private Transform spriteTransform;
        private string scale = "2.0";

        void Start()
        {
            spriteTransform = GetComponent<Transform>();
            spriteTransform.localScale = new Vector3(float.Parse(scale), float.Parse(scale), 1f);
        }
    }
}
