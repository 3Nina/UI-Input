using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SumaYResultadoUI : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    public TextMeshProUGUI txtNumero;
    int num1;
    int num2;

    void Start()
    {
        txtNumero.text = "";

    }

    public void SumarYMostrar()
    {
        num1 = int.Parse(inputNum1.text);  // cpnvertir string a int
        num2 = int.Parse(inputNum2.text);

        txtNumero.text = (num1 + num2).ToString();  //convertir la opersacion a string por eso parentesis
        Debug.Log("Sumando!");
    }
}
