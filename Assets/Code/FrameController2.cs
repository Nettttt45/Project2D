using UnityEngine;

public class FrameController2 : MonoBehaviour
{
    public float rotateSpeed = 100f;
    public float returnSpeed = 100f;
    public float maxRotation = 360f;

    private float targetRotation = 0f;
    private float currentRotation = 0f;

    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            targetRotation = maxRotation; // เปลี่ยนจาก -maxRotation เป็น +maxRotation
        }
        else
        {
            targetRotation = 0f;
        }

        currentRotation = Mathf.MoveTowards(currentRotation, targetRotation, (targetRotation == 0 ? returnSpeed : rotateSpeed) * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0f, 0f, currentRotation);
    }
}
