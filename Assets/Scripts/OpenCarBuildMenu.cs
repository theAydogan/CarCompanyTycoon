using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCarBuildMenu : MonoBehaviour
{
    public GameObject CarBuildMenu;
    

    public void OpenMenu()
    {
        CarBuildMenu.SetActive(true);
    }

    public void CloseMenu(){
        if (CarBuildMenu.activeSelf){
            CarBuildMenu.SetActive(false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        CarBuildMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
