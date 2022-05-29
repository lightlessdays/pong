using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rigidBody2D;
    [SerializeField]
    private float _speed = 100.0f;
    private float previousx;
    private float currentx;
    private float currenty;
    private float previousy;
     
    // Start is called before the first frame update
    void Start()
    {
        StartForce();
    }

    // Update is called once per frame
    void Update()
    {
        currentx = transform.position.x;
        currenty = transform.position.y;
        if (previousx == currentx || previousy == currenty) {
            float x = Random.value > 0.5 ? -0.8f : 0.8f;
            float y = Random.value > 0.5 ? -0.8f : 0.8f;
            _rigidBody2D.AddForce(new Vector2(x, y));
        }

        previousx = currentx;
        previousy = currenty;
    }

    void StartForce() {
        float x = Random.value > 0.5 ? 1f : -1f;
        float y = Random.Range(-1f, 1f);
        _rigidBody2D.AddForce(new Vector2(x, y)*_speed);
    }

    public void AddForce(Vector2 force) {
        _rigidBody2D.AddForce(force);
    }

    private void RestartGame()
    {
        _rigidBody2D.position = Vector3.zero;
        _rigidBody2D.velocity = Vector3.zero;
        StartForce();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "deathwall") {
            RestartGame();
            GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>().ComputerScore();

        }
    }
}
