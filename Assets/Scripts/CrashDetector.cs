using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("ops!, we have crashed!");
    }
}
