using UnityEngine;

public class FrameController : MonoBehaviour
{
    public float rotateSpeed = 100f;   // ความเร็วการหมุน
    public float returnSpeed = 100f;   // ความเร็วการหมุนกลับ
    public float maxRotation = 360f;    // หมุนซ้ายสุดแค่กี่องศา (เช่น -15 องศา)
    
    private float targetRotation = 0f; // เป้าหมายที่ต้องการให้หมุนไป
    private float currentRotation = 0f;

    void Update()
    {
        // ถ้ากดปุ่มเมาส์ซ้ายหรือ space bar → ตั้งเป้าหมุนไปทางซ้าย
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            targetRotation = -maxRotation;
        }
        else
        {
            targetRotation = 0f; // ปล่อย → กลับไปตำแหน่งเดิม
        }

        // ค่อย ๆ หมุนไปยังเป้าหมายแบบนุ่มนวล
        currentRotation = Mathf.MoveTowards(currentRotation, targetRotation, (targetRotation == 0 ? returnSpeed : rotateSpeed) * Time.deltaTime);
        
        transform.rotation = Quaternion.Euler(0f, 0f, currentRotation);
    }
}
