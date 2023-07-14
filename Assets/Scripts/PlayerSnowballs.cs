using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 스노우볼 발사

// 사용자가 버튼을 누르면
// 공장에서 스노우볼이 나오고
// 스노우볼이 발사된다.

public class PlayerSnowballs : MonoBehaviour
{

    // 스노우볼을 찍어낼 공장
    public GameObject snowballFactory;

    // 스노우볼이 나올 총구(?)
    public GameObject snowballPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 만약 사용자가 발사 버튼을 클릭한다면?
        if (Input.GetButtonDown("Fire1"))
        {
            // 공장에서 스노우볼을 만든다.
            GameObject snowball = Instantiate(snowballFactory);

            // 스노우볼을 발사한다. == 스노우볼을 총구에 가져다놓기
            snowball.transform.position = snowballPosition.transform.position;
        }
    }
}
