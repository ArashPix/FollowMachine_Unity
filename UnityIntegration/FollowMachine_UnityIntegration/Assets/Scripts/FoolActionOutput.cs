using System.Collections;
using System.Collections.Generic;
using FMachine;
using FollowMachineDll.Attributes;
using UnityEngine;

public class FoolActionOutput : MonoBehaviour
{
    public bool outputExists = false;
    
    [FollowMachine("Is there any output?", "Yes,No")]
    public void BoolOutput()
    {
        FollowMachine.SetOutput(outputExists ? "Yes":"No");
    }
}
