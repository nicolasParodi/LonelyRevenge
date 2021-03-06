﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrengthUI : MonoBehaviour {

    [SerializeField] private Text nameText;
    [SerializeField] private Text levelText;
    [SerializeField] private Text expText;
    [SerializeField] private Text atributsPointsText;
    [SerializeField] private Text classhText;
    [SerializeField] private Text strengthText;
    [SerializeField] private Text dexterityText;
    [SerializeField] private Text vitalityText;
    [SerializeField] private Text energyText;
    [SerializeField] private Text goldText;
    [SerializeField] private PlayerBase player;

	// Use this for initialization
	void Start ()
    {
        UpdateText();	
	}
	
    public void UpdateText()
    {
        nameText.text = player.name;
        classhText.text = player.kind.ToString();
        levelText.text = Mathf.RoundToInt(player.lvl).ToString();
        expText.text = Mathf.RoundToInt(player.xp).ToString();
        atributsPointsText.text = Mathf.RoundToInt(player.atributesPoint).ToString();
        strengthText.text = Mathf.RoundToInt(player.atributes.strength).ToString();
        dexterityText.text = Mathf.RoundToInt(player.atributes.dexterity).ToString();
        vitalityText.text = Mathf.RoundToInt(player.atributes.vitality).ToString();
        energyText.text = Mathf.RoundToInt(player.atributes.energy).ToString();
        goldText.text = Mathf.RoundToInt(player.money).ToString();
    }
}
