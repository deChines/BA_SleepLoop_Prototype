using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARSelector : MonoBehaviour
{
  [SerializeField] GameObject[] targets;

   GameObject currentTarget;
   int targetIndex;


   void Start()
   {
       ChangeTarget();
   }


   void ChangeTarget()
   {
       if (targets.Length > targetIndex)
       {
           if (currentTarget != null)
           {
               currentTarget.SetActive(false);
           }

           currentTarget = targets[targetIndex];
           currentTarget.SetActive(true);
           targetIndex++;
       }
   }


   public void OnClickButton()
   {
       ChangeTarget();
   }
}
