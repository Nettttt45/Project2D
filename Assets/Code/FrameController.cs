using UnityEngine;

public class FrameController : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float returnSpeed = 50f;

    private bool isRotatingLeft = false;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            isRotatingLeft = true;
        }
        else
        {
            isRotatingLeft = false;
        }
    }

    void FixedUpdate()
    {
        float rotation = isRotatingLeft ? rotationSpeed : -returnSpeed;
        transform.Rotate(0, 0, rotation * Time.fixedDeltaTime);
    }
}
