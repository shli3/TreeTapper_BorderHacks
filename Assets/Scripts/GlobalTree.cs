using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTree : MonoBehaviour
{

    public static int TreeCount;
    public GameObject TreeDisplay;
    public int InnerTree;

    // Update is called once per frame
    void Update()
    {
        InnerTree = TreeCount;
        TreeDisplay.GetComponent<Text>().text = "Trees: " + InnerTree;
    }
}
