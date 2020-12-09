using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DvLog : MonoBehaviour
{
    public void Log(string msg)
    {
    	// v1.0.6
        Debug.Log($"[DvLog]{msg}");
    }
}
