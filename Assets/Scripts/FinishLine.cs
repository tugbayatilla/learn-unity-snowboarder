using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Passed the finish line.");
    }
}
