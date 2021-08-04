using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponContainer : MonoBehaviour
{
   public static readonly gun Pistol = new gun(0.35f, 1, 0.15f, 9f, 1 ,"Pistol");

   public static List<gun> guns;

   private void Start(){
        //weapons = new List<gun>();
        guns.Add(Pistol);

   }
}
