using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����Ű asdw�� �޾Ƽ� ����� �̵� ��Ű��

// �Է� ���� Ű�� �ش��ϴ� �������� ������Ʈ�� �̵���Ų��.
// ����ڿ��� ���� �̵�Ű �Է��� �޴´�.
// ����ڸ� �̵� ��Ű�� �ʹ�.
public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 5 * Time.deltaTime);
    }
}
