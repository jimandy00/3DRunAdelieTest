using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����캼 �߻�

// ����ڰ� ��ư�� ������
// ���忡�� ����캼�� ������
// ����캼�� �߻�ȴ�.

public class PlayerSnowballs : MonoBehaviour
{

    // ����캼�� �� ����
    public GameObject snowballFactory;

    // ����캼�� ���� �ѱ�(?)
    public GameObject snowballPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� ����ڰ� �߻� ��ư�� Ŭ���Ѵٸ�?
        if (Input.GetButtonDown("Fire1"))
        {
            // ���忡�� ����캼�� �����.
            GameObject snowball = Instantiate(snowballFactory);

            // ����캼�� �߻��Ѵ�. == ����캼�� �ѱ��� �����ٳ���
            snowball.transform.position = snowballPosition.transform.position;
        }
    }
}
