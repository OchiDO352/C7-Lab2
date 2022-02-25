using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
   public void getAmimatorScream(){
       this.GetComponent<Animator>().Play("Scream");
   }

   public void getAmimatorWalk(){
       this.GetComponent<Animator>().Play("Walk");
   }
}
