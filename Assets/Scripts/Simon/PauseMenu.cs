using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject pausemenu;

    bool isOpen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isOpen == false)
        {
            isOpen = true;
            pausemenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            pausemenu.SetActive(false);
            isOpen = false;
            Time.timeScale = 1;
        }
    }
}
