using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3 : MonoBehaviour
{
    public GameObject Game3spawn;
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
        other.transform.position = Game3spawn.transform.position;
    }
}
