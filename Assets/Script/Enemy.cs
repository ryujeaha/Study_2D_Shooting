using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Target;
    public float speed;
    // Start is called before the first frame update
    // Update is called once per frame

    private void Start() {
        Target = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,Target.position, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(this.gameObject);
    }

    
}
