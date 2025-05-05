using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo; // Es el componente que se quiere modificar

    void Start()
    {
        txtSaludo.text = ""; //.text porque es la propiedad
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
