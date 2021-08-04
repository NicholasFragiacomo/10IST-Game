using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    private float fireRate;
    private float bullets;
    private float spread;
    private float speed;
    private int damage;
    private string description; 
    
    public gun(float fireRate, float bullets , float spread , float speed , int damage, string description){
        this.fireRate = fireRate;
        this.bullets = bullets;
        this.spread = spread;
        this.speed = speed;
        this.damage = damage;
        this.description = description;
    }


}
