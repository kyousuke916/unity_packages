using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DvLog : MonoBehaviour
{
    public void Log(string msg)
    {
        Debug.Log($"[DvLog]{msg}");
    }
}
