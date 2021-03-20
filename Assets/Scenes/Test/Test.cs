using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float fireAmount = 0f;

    Rigidbody rb;

    private void Update()
    {
        GetComponent<Test>().fireAmount += 1;
    }
}
