using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TechMenuControl : MonoBehaviour
{

    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Settings;

    [SerializeField] private CarClass selected_car;

    public void ShowVusialSettings()
    {
        Menu.SetActive(false);
        Settings.SetActive(true);
    }

    public void CloseVusialSettings()
    {
        Menu.SetActive(true);
        Settings.SetActive(false);
    }

    public void StartGame()
    {
    	SceneManager.LoadScene("Town");
    }

}
