using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider slider;

    public void SetEnergy(int energy){
        slider.value = energy;
    }

    public int GetEnergy(){
        return (int)slider.value;
    }

    public void SetMaxEnergy(int energy){
        slider.maxValue = energy;
        slider.value = energy;
    }
}
