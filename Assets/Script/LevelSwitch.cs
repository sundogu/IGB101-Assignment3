using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    GameManager gameManager;
    
    public AudioSource sfx;
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.transform.tag == "Player") {
            if (gameManager.levelComplete) {
                StartCoroutine(PlaySFXAndLoadNextScene());
                
            }
        }
    }

    private IEnumerator PlaySFXAndLoadNextScene() {
        sfx.Play();
        yield return new WaitForSeconds(4);

        SceneManager.LoadScene(nextLevel);
    }
}
