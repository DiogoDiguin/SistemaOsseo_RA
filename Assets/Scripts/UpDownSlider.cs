using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UpDownSlider : MonoBehaviour
{
    [SerializeField] private Slider positionSlider;  // Referência ao slider
    [SerializeField] private float multiplicador = 1;  // Multiplicador para a altura
    private Vector3 initialPosition;

    private void Start() {
        if (positionSlider != null) {
            // Captura a posição inicial do GameObject
            initialPosition = transform.position;

            // Adiciona o listener para atualizar a posição conforme o valor do slider muda
            positionSlider.onValueChanged.AddListener(OnSliderValueChanged);
        }
    }

    void OnSliderValueChanged(float value) {
        // Atualiza apenas a posição Y do objeto, com base no valor do slider
        transform.position = new Vector3(
            initialPosition.x, 
            initialPosition.y + (value * multiplicador), 
            initialPosition.z
        );
    }

    private void OnDestroy() {
        if (positionSlider != null) {
            positionSlider.onValueChanged.RemoveListener(OnSliderValueChanged);
        }
    }
}
