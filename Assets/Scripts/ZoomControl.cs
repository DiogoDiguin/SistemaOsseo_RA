using UnityEngine;

public class ZoomControl : MonoBehaviour
{
    [SerializeField] private Camera arCamera; // Renomeado de 'camera' para 'arCamera'
    [SerializeField] private float zoomSpeed = 10f;
    [SerializeField] private float minDistance = 1f; // Distância mínima da câmera ao objeto
    [SerializeField] private float maxDistance = 10f; // Distância máxima da câmera ao objeto

    private Vector3 initialPosition;

    void Start()
    {
        // Armazena a posição inicial da câmera
        initialPosition = arCamera.transform.position;
    }

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            // Calcula a nova distância da câmera
            float distance = Vector3.Distance(arCamera.transform.position, initialPosition);
            distance -= scroll * zoomSpeed;
            distance = Mathf.Clamp(distance, minDistance, maxDistance);

            // Ajusta a posição da câmera
            arCamera.transform.position = initialPosition + arCamera.transform.forward * distance;
        }
    }
}
