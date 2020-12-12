using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void optionButton(){
        SceneManager.LoadScene("Option");
    }
    
    public void startButton(){
        SceneManager.LoadScene("Main");
    }
}
