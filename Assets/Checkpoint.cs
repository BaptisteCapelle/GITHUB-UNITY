using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    GameObject point;
    Vector3 newposition;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        newposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -1f)
        {
            transform.position = newposition;
        }
    }
}
