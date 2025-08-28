using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enginePanelMenu : MonoBehaviour
{
    public GameObject enginePanel;
    public GameObject inlineSix;
    
    private bool isInlineSixSelected = false; // Track button state
    
    // Values you can set based on button state
    public string selectedEngineType = "None";
    public int enginePower = 0;
    public float engineEfficiency = 0f;
    public bool hasEngine = false;

    public void OpenPanel(){
        enginePanel.SetActive(true);
    }

    public void activeInlineSix(){
        inlineSix.SetActive(true);
        if (inlineSix.activeSelf){

            isInlineSixSelected = !isInlineSixSelected;
            

            if (isInlineSixSelected) {
                inlineSix.GetComponent<Image>().color = Color.green; 
                

                selectedEngineType = "Inline-6";
                enginePower = 200;
                engineEfficiency = 0.85f;
                hasEngine = true;
                
                Debug.Log("Inline-6 Engine Selected! Power: " + enginePower + "hp");
            } else {
                inlineSix.GetComponent<Image>().color = Color.white; 
                

                selectedEngineType = "None";
                enginePower = 0;
                engineEfficiency = 0f;
                hasEngine = false;
                
                Debug.Log("Engine deselected");
            }
        }
    }

    public void ClosePanel(){
        if (enginePanel.activeSelf){
            enginePanel.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        enginePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
