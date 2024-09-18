using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderRotate : MonoBehaviour
{
    [SerializeField] private Slider rotationSlider;
    [SerializeField] private Vector3 rotationAxis = Vector3.up;
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private float multiplicador = 1;

    private void Start() {
        if(rotationSlider != null){
            rotationSlider.onValueChanged.AddListener(OnSliderValueChanged);
        }
    }

    void OnSliderValueChanged(float value){
        transform.rotation = Quaternion.Euler(rotationAxis * (value * multiplicador) * rotationSpeed);
    }

    private void OnDestroy() {
        if(rotationSlider != null){
            rotationSlider.onValueChanged.RemoveListener(OnSliderValueChanged);
        }
    }
}
