using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    GameManager gameManager;
    public GameObject[] items;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.transform.tag == "Player") {
            gameManager.currentPickups += 1;
            
            if (items != null && items.Length > 0) {
                foreach (var item in items) {
                    Destroy(item);
                }
            }

            Destroy(this.gameObject);
        }
    }
}
