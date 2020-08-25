using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BulletController : MonoBehaviour
{
    Transform player;
    //GameManager hp;
    bool isX = true;

    private float speed;
    private bool isXWay;

    private const float minSpeed = 0.02f;
    private const float maxSpeed = 0.04f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").transform;

        //hp = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (Random.Range(0, 2) == 0)
            isXWay = true;
        else
            isXWay = false;
        if (Random.Range(0, 2) == 0)
            speed = Random.Range(minSpeed, maxSpeed);
        else
            speed = -(Random.Range(minSpeed, maxSpeed));

        if (isXWay)
        {
            if (speed > 0)
            {
                transform.position = new Vector3(-10f, Random.Range(-4f, 4f), 0);
                transform.Rotate(0, 0, 90f);
            }
            else
            {
                transform.position = new Vector3(10f, Random.Range(-4f, 4f), 0);
                transform.Rotate(0, 0, 270f);
            }
        }
        else
        {
            if (speed > 0)
            {
                transform.position = new Vector3(Random.Range(-8f, 8f), -6f, 0);
                transform.Rotate(0, 0, 180f);
            }
            else
                transform.position = new Vector3(Random.Range(-8f, 8f), 6f, 0);
        }


    }

    // Update is called once per frame
    void Update()
    {

        if (isXWay)
        {
            if (speed > 0)
                transform.Translate(0, speed, 0);
            else
                transform.Translate(0, speed, 0);
        }
        else
        {
            if (speed > 0)
                transform.Translate(0, speed, 0);
            else
                transform.Translate(0, speed, 0);
        }


        // transform.Translate(0, -0.02f, 0);

        Vector2 p1 = transform.position; //벡터 2의 p1 이란 놈은 == 돌맹이의 벡터는 == 위치 이다. 
        Vector2 p2 = player.position; //자동차의 포지션 값 
        Vector2 dir = p1 - p2;

        float d = dir.magnitude; //== 두 벡터의 크기(길이) 를 가져옴 

        float r1 = 0.7f;
        float r2 = 0.35f;

        if (d <= r1 + r2) //충돌 했다면 
        {
            Destroy(gameObject);
            //hp.DecreaseHP();
        }
        //불릿이 화면 밖으로 나가면
        if (transform.position.x > 9.3f || transform.position.x < -9.3f ||
            transform.position.x > 5.5f || transform.position.x > -5.5f)
        {
            Destroy(gameObject);//지금 즉시삭제
        }



    }

}
