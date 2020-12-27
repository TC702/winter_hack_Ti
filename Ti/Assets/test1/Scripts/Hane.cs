using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hane : MonoBehaviour
{
    public GameObject hane;
    public float range;
    static Rigidbody rg;
    static Transform ts;
    static Vector3 force = new Vector3(1f,3f,1f);
    private bool atackside = true;
    static float default_height;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(ChangeSide());
        rg = hane.GetComponent<Rigidbody>();
        ts = hane.GetComponent<Transform>();
        default_height = ts.position.y;
    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //rg.AddForce(force, ForceMode.Impulse);
        }
    }

    private IEnumerator ChangeSide()
    {
        while (true)
        {
            while (true)
            {
                if (transform.position.y - default_height > 8)
                {
                    var y = 0.0f;
                    if (!atackside)
                    {
                        y = Random.Range(0f - range, 0f + range);
                        atackside = true;
                    }
                    else
                    {
                        y = Random.Range(180f - range, 180f + range);
                        atackside = false;
                    }
                    this.transform.rotation = Quaternion.Euler(0, y, 0);
                    break;
                }
                yield return new WaitForSeconds(0.2f);
            }

            yield return new WaitForSeconds(2.0f);
        }

    }
}
