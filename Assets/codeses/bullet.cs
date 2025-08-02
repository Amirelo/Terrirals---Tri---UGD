using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int speed = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        KillBlock script = collision.gameObject.GetComponent<KillBlock>();
        if (script != null)
        {
            script.health = script.health - 1000000;
            print(script.health);
            if (script.health <= 0)
            {
                Destroy(script.gameObject);
            }
            Destroy(gameObject);
            //Destroy(collision.gameObject);
        }
    }
}
