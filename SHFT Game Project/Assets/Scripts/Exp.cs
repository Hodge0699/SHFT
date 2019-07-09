using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp : MonoBehaviour
{
    //players current level
    public int Level = 1;
    //players current exp amount 
    public int currentExp = 0;
    //amount of exp needed to level up 
    public int ExpBase = 10;
    //amount of exp left for level up
    public int ExpLeft = 10;
    //the amount of exp that is needed for the next level up will increase 
    public float ExpModifier = 1.15f;


    void Update()
    {
        //base exp given per monster killed 
        // if(BasicMonster.Dead)
        //{
        // gainExp(3_;  
        //}
    }
    public void GainExp(int e)
    {
        currentExp += e;
        if (currentExp >= ExpLeft)
        {
            LvlUp();
        }
    }
    void LvlUp()
    {
        currentExp -= ExpLeft;
        Level++;
        float t = Mathf.Pow(ExpModifier, Level);
        ExpLeft = (int)Mathf.Floor(ExpBase * t);
    }
}
