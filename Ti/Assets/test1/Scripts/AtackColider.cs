using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackColider : MonoBehaviour
{
    public GameObject selfColider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (selfColider.activeSelf)
        {
            //Invoke("SetNotActive", 1);
        }
    }

    void SetNotActive()
    {
        this.gameObject.SetActive(false);
    }
}
