using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentDestroyer : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(DestroyFragment(5));
    }

    IEnumerator DestroyFragment(float t)
    {
        yield return new WaitForSeconds(t);

        Destroy(gameObject);
    }
}
