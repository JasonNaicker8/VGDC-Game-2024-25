using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Events;
//*Author:
//*Jerry Mou Sep 20 2024
//*
//* Modified By:


public class PlayerData : Singleton<PlayerData>
{
    private PlayerStats player;

    private int health;

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            OnHealthChange?.Invoke();
            health = value;
        }
    }

    public UnityEvent OnHealthChange;


    public int maxHealth;

    private int mana;

    public int Mana { get; set; }

    public int maxMana;

    public int experience;

    public int level;


    public PlayerStats Player
    {
        get { return player; }
        set
        {
            OnPlayerConnectToPlayerData?.Invoke();
            player = value;

        }
    }


    private PlayerController playerController;

    public PlayerController PlayerController { get { return playerController; } set { playerController = value; } }


    public UnityEvent OnPlayerConnectToPlayerData;


    //public InventorySystem inventory{get; set;}



    // Start is called before the first frame update
    void Start()
    {
        OnPlayerConnectToPlayerData.AddListener(CheckMultiPlayerCase);
        //OnHealthChange.AddListener(DisplayMessage);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckMultiPlayerCase()
    {
       

        if (player != null)
            Debug.LogWarning("It seems there is two player on the scene.");
    }
}
