using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTree : MonoBehaviour
{

    public AudioSource TreeSFX;

  public void ButtonClick(){
      TreeSFX.Play();
      GlobalTree.TreeCount += 1;
  }
}
