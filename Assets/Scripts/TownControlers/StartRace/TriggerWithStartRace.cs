using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerWithStartRace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Race1")
        {
             SceneManager.LoadScene("SampleScene");
             Debug.Log("------------");
        }
    }
}
