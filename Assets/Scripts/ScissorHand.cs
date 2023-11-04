using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorHand : RPSHand
{
    public override string Judge(string _name)
    {
        if (_name == "R:Paper")
        {
            return "lose";
        }
        else if (_name == "R:Rock")
        {
            return "win";
        }
        else
        {
            return "tie";
        }
    }
}