using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleScript : MonoBehaviour
{
    public BoxCollider2D playerPaddle;
    public float moveSpeed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        
        {
            playerPaddle.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        
        {
            playerPaddle.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

    }
}
