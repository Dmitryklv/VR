using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VRtest2 : MonoBehaviour
{
    public int k = 10;
    public Text txt;
    void FixedUpdate()
    {
    }
    public void OnCollisionEnter(Collision collision)
    {
        k--;
        txt.text = k.ToString();
    }
}
