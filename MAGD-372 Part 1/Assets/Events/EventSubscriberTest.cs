using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriberTest : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        EventTester eventTester = GetComponent<EventTester>();
        eventTester.OnSpacePressed += EventTester_OnSpacePressed;
        eventTester.OnEPressed += EventTester_OnEPressed;
        
    }

    private void EventTester_OnSpacePressed(object sender, EventTester.OnSpacePressedEventArgs e)
    {
        Debug.Log("Spawning Bouncy Cube #" + e.spaceCount);
        GameObject newCube = Instantiate(cubePrefab);
    }

    private void EventTester_OnEPressed(object sender, EventTester.OnEPressedEventArgs e)
    {
        Debug.Log("Spawning Heavy Ball #" + e.eCount);
        GameObject newBall = Instantiate(ballPrefab);
    }
}
