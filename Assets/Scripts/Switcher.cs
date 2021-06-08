using UnityEngine;
using UnityEngine.UI;

public class Switcher : MonoBehaviour
{
    [SerializeField] private Text text;

    public void Switch()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
            text.text = "Show";
        }
        else
        {
            gameObject.SetActive(true);
            text.text = "Hide";
        }
    }
}
