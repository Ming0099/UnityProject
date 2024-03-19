using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도 조절을 위한 변수

    void Update()
    {
        // 키보드 입력을 감지하여 오브젝트를 움직임
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 방향 계산
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;

        // 현재 위치에 이동을 적용
        transform.Translate(movement);
    }
}
