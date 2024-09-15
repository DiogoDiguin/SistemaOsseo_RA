using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float sensitivity = 10f;
    private bool isRotating = false;

    void Update()
    {
        // Detectar quando o botão esquerdo do mouse é pressionado
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
        }

        // Detectar quando o botão esquerdo do mouse é solto
        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        // Aplicar rotação enquanto o botão esquerdo está pressionado
        if (isRotating)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            // Rotacionar o GameObject vazio (pai) ao redor de seus eixos locais
            transform.Rotate(Vector3.up, -mouseX, Space.Self); // Rotação em torno do eixo Y
            transform.Rotate(Vector3.right, mouseY, Space.Self); // Rotação em torno do eixo X
        }
    }
}
