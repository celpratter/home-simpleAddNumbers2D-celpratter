using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;
    public Button btn_add;
    public Button btn_reset;

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        result.text = NumbersAdd(a, b).ToString();
        ipVarA.interactable = false;
        ipVarB.interactable = false;
        btn_add.interactable = false;
        btn_reset.interactable = true;
    }
    private float NumbersAdd(float variableA, float variableB)
    {
        float result = variableA + variableB;
        return result;
    }
    public void Reset()
    {
        ipVarA.text = "0";
        ipVarB.text = "0";
        result.text = "Result";
        ipVarA.interactable = true;
        ipVarB.interactable = true;
        btn_add.interactable = true;
        btn_reset.interactable = false;
    }
}
