using UnityEngine;

public class Trap : MonoBehaviour
{
    private Animation _animation;

    void Start()
    {
        _animation = GetComponent<Animation>();
    }
    
    private void OnTriggerStay(Collider other)
    {        
       _animation.Play();
        Debug.Log("Was trapped");
    }
}
