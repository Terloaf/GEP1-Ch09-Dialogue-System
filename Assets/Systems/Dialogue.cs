using UnityEngine;
using System.Collections;
using System.Collections.Generic;



[System.Serializable]
public class Dialogue
{
    public string naming;

    [TextArea(3, 10)]
    public string[] sentences;
 
}
