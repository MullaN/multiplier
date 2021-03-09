using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = .1f;

    // Start is called before the first frame update

    Rigidbody2D player;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement(){
        Vector2 newVelocity = new Vector2(0.0f, 0.0f);
        if (Input.GetKey(KeyCode.W)){
            newVelocity.y += moveSpeed;
        }
        if (Input.GetKey(KeyCode.S)){
            newVelocity.y -= moveSpeed;
        }
        if (Input.GetKey(KeyCode.D)){
            newVelocity.x += moveSpeed;
        }
        if (Input.GetKey(KeyCode.A)){
            newVelocity.x -= moveSpeed;
        }
        player.velocity = newVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name.Contains("Enemy")){
            SceneManager.LoadScene("GameOver");
        }
    }
}
