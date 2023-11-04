using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperHand : RPSHand
{
    public override string Judge(string _name)
    {
        if(_name == "R:Paper")
        {
            return "tie";
        }
        else if(_name == "R:Rock")
        {
            return "lose";
        }
        else
        {
            return "win";
        }
    }
}