using UnityEngine;

public class CameraTargetFollow : MonoBehaviour
{
    public Transform target;  // A cabeça do personagem
    public float smoothSpeed = 10f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}