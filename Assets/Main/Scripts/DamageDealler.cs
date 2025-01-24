using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageDealler : MonoBehaviour
{
    [SerializeField] private float damage;
               
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out Healh healh))
        {
            healh.TakeDamage(damage);  

            if (!healh.IsAlive)
            {
                RestartLVL();
            }
        }
    }
    private void RestartLVL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}