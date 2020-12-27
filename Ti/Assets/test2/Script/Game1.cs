using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    public GameObject Game1spawn;
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
        other.transform.position = Game1spawn.transform.position;
    }
}
