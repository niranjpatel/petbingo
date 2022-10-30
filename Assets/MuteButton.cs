using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
   public Texture2D mute; 
   public Texture2D sound;

   public RawImage im;

   public AudioSource source;

   public bool isMute = false;

   public void ClickSound()
   {
        if(isMute)
        {
            im.texture = sound;
            source.Play();
            isMute = false;
        }
        else
        {
            im.texture = mute;            
            source.Stop();
            isMute = true;
        }
   }
}
