﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehavorScript : MonoBehaviour
{
    public AudioClip musicClipOne;

        public AudioClip musicClipTwo;

    public AudioSource musicSource;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            {
            musicSource.clip = musicClipOne;
            musicSource.Play();

            }

        if (Input.GetKeyUp(KeyCode.W))
            {
             musicSource.Stop();

            }

        if (Input.GetKeyDown(KeyCode.R))
            {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            }

        if (Input.GetKeyUp(KeyCode.R))
            {
            musicSource.Stop();

            }

        if (Input.GetKeyDown(KeyCode.L))
            {
            musicSource.loop = true;
            }

        if (Input.GetKeyUp(KeyCode.L))
            {
             musicSource.loop = false;
            }
   }
}