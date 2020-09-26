using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickTree : MonoBehaviour
{

    public AudioSource TreeSFX;
    public GameObject PlantTree;

  public void ButtonClick(){
      TreeSFX.Play();
      PlantTree.GetComponent<Animation>().Play("TreeBob");
      GlobalTree.TreeCount += 1;
  }
}
