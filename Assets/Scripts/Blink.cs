using System.Collections;
using UnityEngine;

public class Blink : MonoBehaviour
{
    private MeshRenderer mesh;
    
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        StartCoroutine(Run());
    }

    IEnumerator Run()
    {
        yield return new WaitForSeconds(0.5f);
        mesh.enabled = !mesh.enabled;
        StartCoroutine(Run());
    }
}
