using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        Button jugar = root.Q<Button>("btnJugar");

        jugar.clicked += Jugar;
    }

    void Update()
    {
        
    }
    void Jugar()
    {
        SceneManager.LoadScene("MainGame");
    }
}