﻿using UnityEngine;
using UnityEngine.UI;

namespace CGT.Unity.Fungus.SBSaveSys
{
    /// <summary>
    /// Handles displaying a save slot's description. This is the SBSS's default 
    /// implementation thereof, using Unity's default Text component.
    /// </summary>
    [AddComponentMenu("CGT SB SaveSys/UI/Default/Save Slot Description")]
    public class BasicSaveSlotDescription : SaveSlotDescription<Text> { }
}