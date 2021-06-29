using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(-1f * Time.deltaTime * 5f, 0, 0);
    }
}
