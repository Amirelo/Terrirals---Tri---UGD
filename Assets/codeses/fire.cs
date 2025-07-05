using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 offset = new Vector3(0, 2, 3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject bClone = Instantiate(bullet, transform.position + offset, transform.rotation);
            Destroy(bClone, 10);
        }
    }
}
