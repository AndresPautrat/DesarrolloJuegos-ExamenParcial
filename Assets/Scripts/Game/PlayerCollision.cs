using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    Text score;
    Text lifes;

    int scorePoints = 0;
    int lifesPoints = 2;
    private void Start()
    {
        lifes = GameObject.Find("Lifes").GetComponent<Text>() ;
        score = GameObject.Find("Score").GetComponent<Text>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag != gameObject.tag)
        {
            if (lifesPoints == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            Destroy(other.gameObject);
            lifes.text = lifesPoints.ToString();
            lifesPoints -= 1;
        }
        else
        {
            scorePoints += 10;
            score.text = scorePoints.ToString();
        }
    }
}
