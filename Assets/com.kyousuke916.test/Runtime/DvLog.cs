using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.kyousuke916.test
{
    public class DvLog : MonoBehaviour
    {
        void Awake()
        {
            Log("Hello v1.0.7");
        }

        public void Log(string msg)
        {
            Debug.Log($"[DvLog]{msg}");
        }
    }
}