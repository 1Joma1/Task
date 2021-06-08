using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private Slider x, y, z;
    
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(x.value, y.value, z.value);
    }
}
