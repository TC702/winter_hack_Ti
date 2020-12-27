using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4 : MonoBehaviour
{
    public GameObject Game4spawn;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Triger
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = Game4spawn.transform.position;
    }
}
