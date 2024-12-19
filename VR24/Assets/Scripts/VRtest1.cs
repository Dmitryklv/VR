using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class VRtest1 : MonoBehaviour
{
    public int k = 0;
    public Text txt;
    public GameObject test;
    void FixedUptade()
    {
        k++;
        txt.text = k.ToString();
    }
    public void ClickButton()
    {
        test.SetActive(!(test.activeSelf));
    }
}