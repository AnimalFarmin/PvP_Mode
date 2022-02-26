using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerSelector: MonoBehaviour
{
   public Image[] SelectionBoxes;
   public GameObject[] prefabs;

   void Start()
   {
       foreach (var img in this.SelectionBoxes)
       {
           img.gameObject.SetActive(false);
       }
       this.Select(0);
   }

   public void Select(int index)
   {
       foreach (var img in this.SelectionBoxes)
       {
           img.gameObject.SetActive(false);
       }

       this.SelectionBoxes[index].gameObject.SetActive(true);
       PlayerStorage.playerPrefab = this.prefabs[index]; 
   }
}
