using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ���� ������ �Ѿ�

// �Ѿ��� ����,  �̵� �ӵ�
// �Ѿ� �߻�

public class Bullet : MonoBehaviour
{

    public float speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����
        Vector3 dir = Vector3.up;

        // �̵�
        transform.position += dir * speed * Time.deltaTime;
    }
}
