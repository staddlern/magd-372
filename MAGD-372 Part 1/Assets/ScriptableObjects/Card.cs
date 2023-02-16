using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string effect;
    public Sprite type;
    public Sprite artwork;
    public int energyCost;

    public void Print()
    {
        Debug.Log(name + ": " + effect + " The card costs: " + energyCost + " Energy.");
    }
}
