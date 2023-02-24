using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTester : MonoBehaviour
{
    public event EventHandler<OnSpacePressedEventArgs> OnSpacePressed;
    public event EventHandler<OnEPressedEventArgs> OnEPressed;



    public class OnSpacePressedEventArgs : EventArgs
    {
        public int spaceCount;
    }

    public class OnEPressedEventArgs : EventArgs
    {
        public int eCount;
    }

    private int spaceCount;
    private int eCount;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnSpacePressed != null)
            {
                spaceCount++;
                OnSpacePressed(this, new OnSpacePressedEventArgs {  spaceCount = spaceCount });
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (OnEPressed != null)
            {
                eCount++;
                OnEPressed(this, new OnEPressedEventArgs { eCount = eCount });
            }
        }
    }
}
