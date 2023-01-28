using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TechMenuControl : MonoBehaviour
{

    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Visual_Settings;
    [SerializeField] private GameObject Tech_Settings;

    [SerializeField] private CarClass selected_car;

    public void ShowVusialSettings()
    {
        Menu.SetActive(false);
        Visual_Settings.SetActive(true);
    }

    public void CloseVusialSettings()
    {
        Menu.SetActive(true);
        Visual_Settings.SetActive(false);
    }
    
    public void ShowTechSettings()
    {
        Menu.SetActive(false);
        Tech_Settings.SetActive(true);
    }

    public void CloseTechSettings()
    {
        Menu.SetActive(true);
        Tech_Settings.SetActive(false);
    }

    public void StartGame()
    {
    	SceneManager.LoadScene("Town");
    }

}
