using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, 500, 0);
        }

        //左移動
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.015f, 0, 0);
        }
           
        //右移動
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.015f, 0, 0);
        }

        //落下したときの処理
        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene("SampleScene");
        } 
    }
}
