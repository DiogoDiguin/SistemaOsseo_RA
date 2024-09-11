using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour{
    public float zoomSpeed = 0.1f;
    public float minZoom = 0.5f;
    public float maxZoom = 2.0f;
    private Camera cam;

    void Start (){
        cam = Camera.main;
    }

    void Update (){
        if(Input.touchCount == 2){//Verifica se tem dois dedos na tela
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            //Calcula a distância entre os dois toques no quadro atual e no anterior;
            Vector2 touch1PrevPos = touch1.position - touch1.deltaPosition;
            Vector2 touch2PrevPos = touch2.position - touch2.deltaPosition;

            float prevTouchDeltaMag = (touch1PrevPos - touch2PrevPos).magnitude;
            float touchDeltaMag = (touch1.position - touch2.position).magnitude;

            //Diferença na distância entre os dois toques
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            //Aplica o zoom invertendo a direção
            Zoom(deltaMagnitudeDiff, zoomSpeed);
        }
    }

    void Zoom(float deltaMagnitudeDiff, float speed){
        //Ajusta o tamanho do orth da câmera
        cam.orthographicSize += deltaMagnitudeDiff * speed;

        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minZoom, maxZoom);
    }
}
