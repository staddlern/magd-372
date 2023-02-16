using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class carddisplay : MonoBehaviour
{

    public Card card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI effectText;
    public TextMeshProUGUI energyText;

    public Image typeImage;
    public Image artImage;

    void Start()
    {
        nameText.text = card.name;
        effectText.text = card.effect;

        artImage.sprite = card.artwork;
        typeImage.sprite = card.type;

        energyText.text = card.energyCost.ToString();
    }
}
