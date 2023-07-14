using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 방향키 asdw를 받아서 사용자 이동 시키기

// 입력 받은 키에 해당하는 방향으로 오브젝트를 이동시킨다.
// 사용자에게 방향 이동키 입력을 받는다.
// 사용자를 이동 시키고 싶다.
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
        // Input : 입력 클래스
        // GetAxix : 메서드
        // Unity -> Edit -> Setting -> Input
        // GetAxix 메서드에서 입력한 Stringdmf Input에서 찾아서 가져옴
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        print("h : " + h + ", v : " + v);

        // C = A + B
        // 좌우와 상하를 더하면 방향(dir)으로 갈 수 있다.
        // Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);

        // 설정된 방향 * 속도 * 시간으로 오브젝트 위치를 이동시킨다.
        // transform.Translate(dir * speed * Time.deltaTime);

        // p = p0 + vt로 변경
        transform.position += dir * speed * Time.deltaTime;
    }
}
