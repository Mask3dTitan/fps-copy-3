using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class AmmoBox : MonoBehaviour
{
   
    public int ammoAmount = 200;
    public AmmoType ammoType;
    
    public enum AmmoType
    {
        RifleAmmo,
        PistolAmmo
    }
    


}
