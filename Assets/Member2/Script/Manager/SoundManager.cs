﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    public Sound(TBL_SOUND tc)
    {
        this.name = tc.name;
        this.clip = tc.Sound;
    }
}
public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance = null;

    [SerializeField] Sound[] sfx = null;
    [SerializeField] Sound[] bgm = null;

    [SerializeField] AudioSource bgmPlayer = null;
    [SerializeField] AudioSource[] sfxPlayer = null;

    private void Awake()
    {
        if(!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
		}
        DontDestroyOnLoad(this);

        for(int i=0; i<4; i++)
        {
            bgm[i] = new Sound(TBL_SOUND.GetEntity(i));
        }

        for (int i = 4; i < TBL_SOUND.CountEntities; i++)
        {
            sfx[i - 4] = new Sound(TBL_SOUND.GetEntity(i));
        }
    }
    public void PlayBGM(string p_bgmName)
    {
        for (int i = 0; i < bgm.Length; i++)
        {
            if (p_bgmName == bgm[i].name)
            {
                bgmPlayer.clip = bgm[i].clip;
                bgmPlayer.Play();
            }
        }
    }

    public void StopBGM()
    {
        bgmPlayer.Stop();
    }

    public void PlaySFX(string p_sfxName)
    {
        for (int i = 0; i < sfx.Length; i++)
        {
            if (p_sfxName == sfx[i].name)
            {
                for (int x = 0; x < sfxPlayer.Length; x++)
                {
                    if (sfxPlayer[x] != null)
                    {
                        sfxPlayer[x].clip = sfx[i].clip;
                        sfxPlayer[x].Play();
                        return;
                    }
                        

                }
                Debug.Log("모든 오디오 플레이어가 재생중");
                return;
            }
        }
        Debug.Log(p_sfxName + "이름의 효과음이 없습니다.");

    }
}
