using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        // Bug fixed!

        int a = 1;


        a = a > 0 ? 2 : 3;
    }
}
