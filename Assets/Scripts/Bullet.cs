using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 위로 쏴지는 총알

// 총알의 방향,  이동 속도
// 총알 발사

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
        // 방향
        Vector3 dir = Vector3.up;

        // 이동
        transform.position += dir * speed * Time.deltaTime;
    }
}
