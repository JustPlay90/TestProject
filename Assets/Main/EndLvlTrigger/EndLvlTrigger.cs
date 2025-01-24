using UnityEngine;

public class EndLvlTrigger : MonoBehaviour
{
    [SerializeField] private GameObject endLvlMenu;
       
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
            endLvlMenu.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player"))
            endLvlMenu.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
