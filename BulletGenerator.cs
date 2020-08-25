using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    float span = 1f;//생성시간
    float delta = 0f;//델타타임을 중첩해서 쓰기위해
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //일정주기 반복
        delta += Time.deltaTime;
        if (delta > span)//이전프레임에서 현재프레임까지 걸린시간
        {
            delta = 0f;//초기화
            GameObject go = Instantiate(bulletPrefab);
            //float px = Random.Range(-8.4f, 9.5f);
            //go.transform.position = new Vector3(px,-5.5f, 0);
        }
    }
}
