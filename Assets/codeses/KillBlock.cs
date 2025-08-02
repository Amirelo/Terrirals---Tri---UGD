using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBlock : MonoBehaviour
{
    public Vector3 lapSart;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        print("BSEDEDEDEDEFRGFSDFDRTBESTESRBEBGESSZbr");
        transform.localScale = lapSart;
        transform.rotation = Quaternion.Euler(45, 45, 45);
        transform.position += new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f) * Time.deltaTime;
    }
}
