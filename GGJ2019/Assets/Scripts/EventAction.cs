﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Dialog", menuName = "SceneEvents", order = 1)]
public class EventAction : ScriptableObject
{
    
    public DialogCanvasManager.CharactersToShow LeftCharacter;
    public DialogCanvasManager.CharactersToShow RightCharacter;
    public string dialogText;
    public bool showChoices;

    public string choice1Text;
    public string coice2Text;

    public bool showLeftName;
    public bool showRightName;

     public static void CreateMyAsset()
    {
        EventAction asset = ScriptableObject.CreateInstance<EventAction>();

        AssetDatabase.CreateAsset(asset, "Assets/NewScripableObject.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }

}
