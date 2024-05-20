using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    
    // Pickup and Level Completion
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;
    public Text pickupText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkLevelComplete();
        UpdateGUI();
    }
    
    private void checkLevelComplete() {
        levelComplete = currentPickups >= maxPickups;
    }

    private void UpdateGUI() {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }
}
