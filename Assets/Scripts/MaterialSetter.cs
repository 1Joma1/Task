using UnityEngine;

public class MaterialSetter : MonoBehaviour
{
    [SerializeField] private Material mat;
    private Color color;

    void Start()
    {
        color = mat.color;
        mat.color = Color.red;
    }

    private void OnApplicationQuit()
    {
        mat.color = color;
    }
}