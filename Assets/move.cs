using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ� ������ ���� ����

    void Update()
    {
        // Ű���� �Է��� �����Ͽ� ������Ʈ�� ������
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���� ���
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;

        // ���� ��ġ�� �̵��� ����
        transform.Translate(movement);
    }
}
