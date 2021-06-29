using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    [SerializeField]private Slider slider;

    public void setMax(int value){
        slider.maxValue = value;
        slider.value = value;
    }

    public void setValue(int value){
        slider.value = value;
    }
}
