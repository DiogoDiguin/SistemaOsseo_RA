using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour{
    public float zoomSpeed = 0.1f; // Velocidade do zoom
    public float minZoom = 0.2f;   // Escala mínima
    public float maxZoom = 2.0f;   // Escala máxima
    private Camera cam;

    void Start (){
        cam = Camera.main;
    }

    void Update (){
        if(Input.touchCount == 2){ // Verifica se há dois dedos na tela
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            // Calcula a posição anterior dos dois toques
            Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;
            Vector2 touch2PrevPos = touch2.position - touch2.deltaPosition;

            // Calcula a distância entre os dois toques no quadro anterior e no quadro atual
            float prevTouchDeltaMag = (touch1PrevPos - touch2PrevPos).magnitude;
            float touchDeltaMag = (touch1.position - touch2.position).magnitude;

            // Diferença entre as distâncias calculadas
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // Aplica o zoom invertendo a direção
            Zoom(deltaMagnitudeDiff, zoomSpeed);
        }
    }

    void Zoom(float deltaMagnitudeDiff, float speed){
        // Calcula o fator de escala com base na diferença de magnitude e na velocidade
        float scaleFactor = 1 - deltaMagnitudeDiff * speed;

        // Aplica a escala ao objeto diretamente
        Vector3 newScale = transform.localScale * scaleFactor;

        // Garante que a escala do objeto permaneça dentro dos limites
        newScale.x = Mathf.Clamp(newScale.x, minZoom, maxZoom);
        newScale.y = Mathf.Clamp(newScale.y, minZoom, maxZoom);
        newScale.z = Mathf.Clamp(newScale.z, minZoom, maxZoom);

        // Aplica a nova escala ao objeto
        transform.localScale = newScale;
    }
}
