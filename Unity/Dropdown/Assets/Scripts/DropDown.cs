using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    
    public Image miFondo;
    public TMPro.TMP_Dropdown miDropdown;
    //Asi se crea un color, si lo necesitamos solo seria llamarlo sin la propiedad Color
    Color newColor = new Color(0.4470589f, 0.5137255f, 0.6156863f, 1);

    public void CambioDeColor()
    {
        if(miDropdown.value == 0 )
        {
            miFondo.color = Color.white;
        }
        else if(miDropdown.value == 1 )
        {
            miFondo.color = Color.red;
        }
        else if (miDropdown.value == 2)
        {
            miFondo.color = Color.green;
        }
        else if (miDropdown.value == 3)
        {
            miFondo.color = Color.blue;
        }


    }
}
