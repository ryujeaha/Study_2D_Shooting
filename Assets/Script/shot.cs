using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
     public int shot_speed;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,1,0)* shot_speed * Time.deltaTime);
    }
    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
