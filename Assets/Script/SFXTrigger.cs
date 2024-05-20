using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXTrigger : MonoBehaviour
{
   public AudioSource sfx;

   private void OnTriggerEnter(Collider collision) 
   {
   if (collision.transform.tag == "Player")
		sfx.Play();
   }
}
