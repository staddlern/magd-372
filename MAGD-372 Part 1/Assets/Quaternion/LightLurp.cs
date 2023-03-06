using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLurp : MonoBehaviour
{
    private Vector3 newPosition;

    public float smooth = 2;

    private Color newColor;

    void Start()
    {
        newPosition = transform.position;
        newColor = GetComponent<Light>().color;
    }

    
    void Update()
    {
        ChangePosition();
        ChangeColor();
    }

    void ChangePosition()
    {
        Vector3 positionA = new Vector3(597, 86, 140);
        Vector3 positionB = new Vector3(617, 86, 140);
        Vector3 positionC = new Vector3(597, 86, 160);
        Vector3 positionD = new Vector3(617, 86, 160);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (transform.position.z >= 150)
            {
                newPosition = positionA;
            }
            else
            {
                newPosition = positionC;
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (transform.position.z >= 150)
            {
                newPosition = positionB;
            }
            else
            {
                newPosition = positionD;
            }
        }

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * smooth);
    }
    
    void ChangeColor()
    {
        Color colorA = Color.red;
        Color colorB = Color.green;

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
        {
            if (newColor == colorA)
            {
                newColor = colorB;
            }
            else
            {
                newColor = colorA;

            }
        }
        GetComponent<Light>().color = Color.Lerp(GetComponent<Light>().color, newColor, Time.deltaTime * smooth);
    }
}
