using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] [Range(1f, 10f)] float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //좌,우 이동했을 때 오브젝트 반전
        Vector3 flipMove = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            flipMove = Vector3.left;
            transform.localScale = new Vector3(-0.7f, 0.7f, 1);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            flipMove = Vector3.right;
            transform.localScale = new Vector3(0.7f, 0.7f, 1);
        }

        transform.position += flipMove * moveSpeed * Time.deltaTime;
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(0, 180, 0);
        //    transform.Translate(-0.1f, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(0.1f, 0, 0);
        //}
        //위,아래 이동키
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.05f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.05f, 0);
        }
    }
}
