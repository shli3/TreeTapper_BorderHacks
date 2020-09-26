using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPlant : MonoBehaviour
{

    public bool ATreePlanted = false;
    public static int TreeAdded = 1;

    // Update is called once per frame
    void Update()
    {
        if(ATreePlanted == false){
            ATreePlanted = true;
            StartCoroutine(AutoPlantTree());
        }
    }

    IEnumerator AutoPlantTree(){
        yield return new WaitForSeconds(60);
        GlobalTree.TreeCount += TreeAdded;
        ATreePlanted = false;
    }
}
