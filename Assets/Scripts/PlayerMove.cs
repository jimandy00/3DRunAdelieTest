using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 방향키 asdw를 받아서 사용자 이동 시키기

// 입력 받은 키에 해당하는 방향으로 오브젝트를 이동시킨다.
// 사용자에게 방향 이동키 입력을 받는다.
// 사용자를 이동 시키고 싶다.
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
