using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public GameObject quit;
    private Button quitButton;

    void Start()
    {
        quitButton = quit.GetComponent<Button>();
    }

    void Update()
    {
        if((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
        {
            quitButton.onClick.Invoke();
        }
    }



    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
