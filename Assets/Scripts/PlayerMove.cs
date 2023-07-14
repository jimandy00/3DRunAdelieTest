using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����Ű asdw�� �޾Ƽ� ����� �̵� ��Ű��

// �Է� ���� Ű�� �ش��ϴ� �������� ������Ʈ�� �̵���Ų��.
// ����ڿ��� ���� �̵�Ű �Է��� �޴´�.
// ����ڸ� �̵� ��Ű�� �ʹ�.
public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input : �Է� Ŭ����
        // GetAxix : �޼���
        // Unity -> Edit -> Setting -> Input
        // GetAxix �޼��忡�� �Է��� Stringdmf Input���� ã�Ƽ� ������
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        print("h : " + h + ", v : " + v);

        // C = A + B
        // �¿�� ���ϸ� ���ϸ� ����(dir)���� �� �� �ִ�.
        // Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);

        // ������ ���� * �ӵ� * �ð����� ������Ʈ ��ġ�� �̵���Ų��.
        // transform.Translate(dir * speed * Time.deltaTime);

        // p = p0 + vt�� ����
        transform.position += dir * speed * Time.deltaTime;
    }
}
