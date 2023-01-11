using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControler : MonoBehaviour
{
    [SerializeField] private GameObject car_model;
    [SerializeField] static private SelectedCar selected_car;
    
    [SerializeField] static private string nickname;

    // Start is called before the first frame update
    void Start()
    {
        selected_car = CarClass.GetSelectedCar; 
        //nickname = CarClass.nickname;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
