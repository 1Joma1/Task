using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Animator>().SetTrigger("Play");
    }
}
