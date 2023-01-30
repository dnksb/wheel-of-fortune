using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using System;

enum PartsName
{
    THRESHOLD, FRONTFENDER, FRONTBUMPER, BACKFENDER, BACKBUMPER
}

public class DropDownController : MonoBehaviour
{

    [SerializeField] private Dropdown choice_part;
    [SerializeField] private Dropdown parts;

    [SerializeField] private PartsName part_name;

    static public string car_model;

    [SerializeField] private int car_id;

    void Start()
    {
        part_name = PartsName.FRONTBUMPER;
    }

    public void UpdateChoicePart()
    {
        DataTable scoreboard = DataBase.GetTable($"SELECT * FROM 'all cars model'");

        foreach (DataRow row in scoreboard.Rows)
        {
            var cells = row.ItemArray;

            if(cells[1].ToString() == car_model)
            {
                car_id = Convert.ToInt32(cells[0].ToString());
                break;
            }
        }

        switch (choice_part.value)
        {
            case 0:
                part_name = PartsName.FRONTBUMPER;
                break;
            case 1:
                part_name = PartsName.BACKBUMPER;
                break;
            case 2:
                part_name = PartsName.FRONTFENDER;
                break;
            case 3:
                part_name = PartsName.BACKFENDER;
                break;
            case 4:
                part_name = PartsName.THRESHOLD;
                break;
        }
    }

    public void UpdateParts()
    {

    }
}
