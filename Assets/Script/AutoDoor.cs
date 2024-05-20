using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    public Animation animation;
    public GameObject player;
    public float openProximity = 7.0f;

    private bool doorIsOpen = false;

    // Update is called once per frame
    void Update()
    {
        if (!doorIsOpen) 
        {
            OpenDoor();
        } else {
            CloseDoor();
        }
    }

    private void OpenDoor() {
        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) <= openProximity) {
            if (!animation.isPlaying) {
                // The stupidest way to animate i swear to god
                int i = 0;
                foreach (AnimationState state in animation) {
                    if (i == 0) {
                        animation.Play(state.name);
                        doorIsOpen = true;
                    }

                    i++;
                }
            }
        }
    }

    private void CloseDoor() {
        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) > openProximity) {
            if (!animation.isPlaying) {
                int i = 0;
                foreach (AnimationState state in animation) {
                    if (i == 1) {
                        animation.Play(state.name);
                        doorIsOpen = false;
                    }

                    i++;
                }
            }
        }
    }
}
