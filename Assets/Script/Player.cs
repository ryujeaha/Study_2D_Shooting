using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject shot;
    public float co_atk_speed;
    public float  atk_speed;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Shot(){
        Instantiate(shot,new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,0),Quaternion.identity);
        atk_speed = co_atk_speed;
    }
    // Update is called once per frame
    void Update()
    {
        atk_speed -= Time.deltaTime;
        if(atk_speed <= 0){
            Shot();
        }

        Vector2 vec = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(vec * speed * Time.deltaTime);
    }
}
