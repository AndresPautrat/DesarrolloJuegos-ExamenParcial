using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPlayer : MonoBehaviour
{
    [SerializeField]
    private Button button;
    [SerializeField]
    private string player;
    void Start()
    {
        
        //button = GetElemenById("Button");
        button.onClick.AddListener(() => GoGame());
    }
    

    void GoGame()
    {
        PlayerPrefs.SetString("player", player);
        SceneManager.LoadScene("Game");
    }

}
