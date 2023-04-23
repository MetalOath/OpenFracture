using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(Destruction(5));
    }

    IEnumerator Destruction(float t)
    {
        yield return new WaitForSeconds(t);

        Destroy(gameObject);
    }
}
