using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName ="Weapons", order = 1)]
public class Weapon : ScriptableObject
{
    [Header("General info")]
    public string WeaponName;
    public int damage;
    public string type;
    public Sprite weaponIcon;
    
}
