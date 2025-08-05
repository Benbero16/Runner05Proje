using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] public GameObject gameStartMenu;// start men� paneli i�in
    [SerializeField] public GameObject gameRestartMenu;// Restart men� Paneli i�in
    [SerializeField] public TextMeshProUGUI score;// restart de g�r�nen
    [SerializeField] public TextMeshProUGUI mainScore;// her iki ekrandada g�r�nen

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameStartMenu.SetActive(true);// oyun ba�lad���nda startmenu paneli a��yor
        gameRestartMenu.SetActive(false);// oyun ba�lad���nda reStartMenu panelini kapat�yor.
    }

    // Update is called once per frame
    void Update()
    {
        mainScore.text = "Score : " + playerController.score;

        if (playerController.isDead)
        {
            gameRestartMenu.SetActive(true);
            score.text = "Score : " + playerController.score;

        }

    }
    public void StartGame()
    {
        playerController.isStart = true;// oyun ba�lad�
        playerController.myAnim.SetBool("Run", true);
        gameStartMenu.SetActive(false);
    }

    public void ReStartGame() 
    {
        // SceneManager.LoadScene(0); �ok dinamik de�il
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);// daha dinamik yap�d�r.
    
    }


}
