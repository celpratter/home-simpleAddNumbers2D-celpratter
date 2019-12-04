using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        result.text = NumbersAdd(a, b).ToString();
    }

    private float NumbersAdd(float variableA, float variableB)
    {
        float result = variableA + variableB;
        return result;
    }

}
