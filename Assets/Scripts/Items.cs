﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

    public string itemName;
    public string description;
    public float priceSell;
    public float priceBuy;
	public float ID;
    public float dropChance;
    
    public virtual void Use(PlayerBase _player)
    {

    }

    public virtual void Throw()
    {

    }

    public virtual void Sell(PlayerBase _player)
    {

    }

    public virtual void Buy(PlayerBase _player)
    {

    }

    public virtual void Upgrade(PlayerBase _player)
    {

    }

    public virtual void Repair(PlayerBase _player)
    {

    }
}