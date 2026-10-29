using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Impacto(collision.gameObject);
    }

    private void Impacto(GameObject objetoImpactado)
    {
        if (objetoImpactado.tag == "Respawn")
        {
            Debug.Log("perdiste");
            Reset();
        }
        else if (objetoImpactado.name == "Goal")
        {
            Debug.Log("¡Has ganado!");
            Reset();
        }
    }

    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}