using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHand : RPSHand
{
    public override string Judge(string _name)
    {
        if (_name == "R:Paper")
        {
            return "win";
        }
        else if (_name == "R:Rock")
        {
            return "tie";
        }
        else
        {
            return "lose";
        }
    }
}