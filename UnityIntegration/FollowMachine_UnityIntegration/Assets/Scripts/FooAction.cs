using System.Collections;
using System.Collections.Generic;
using FMachine;
using FollowMachineDll.Attributes;
using UnityEngine;

public class FooAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DebugAction()
    {
        Debug.Log("This is Foo Action.");
    }

    
    public IEnumerator StartACoroutine()
    {
        yield return ACoroutine();
    }
    
    public IEnumerator ACoroutine()
    {
        for (int i = 0; i < 100; i++)
        {
            yield return null;
        }
    }

    public void EventInvoked()
    {
        Debug.Log("Event is invoked...");
    }
}
