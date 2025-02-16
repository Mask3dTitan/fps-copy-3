using UnityEngine;
using System.Collections;
using System.Collections.Generic;   
using static Weapon;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance{get; set; }


public AudioSource ShootingChannel;

public AudioClip P1911shot;
public AudioClip AK47Shot;

public AudioSource reloadingSound1911;
public AudioSource reloadingSoundAK47;  

public AudioSource emptyMagazineSound1911;

public AudioSource throwablesChannel;
public AudioClip grenadeSound;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlayShootingSound(WeaponModel weapon)
    {
        switch (weapon)
        {
            case WeaponModel.Pistol1911:
                ShootingChannel.PlayOneShot(P1911shot);
                break;
            case WeaponModel.AK47:
                ShootingChannel.PlayOneShot(AK47Shot);
                break;
        }

    }
    public void PlayReloadSound(WeaponModel weapon)
    {
        switch (weapon)
        {
            case WeaponModel.Pistol1911:
                ShootingChannel.Play();
                break;
            case WeaponModel.AK47:
                reloadingSoundAK47.Play();
                break;
        }
    }






}
