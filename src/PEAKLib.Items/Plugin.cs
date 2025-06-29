﻿using BepInEx;
using BepInEx.Logging;
using MonoDetour;
using PEAKLib.Core;

namespace PEAKLib.Items;

/// <summary>
/// BepInEx plugin of PEAKLib.Items.
/// </summary>
[BepInAutoPlugin]
[BepInDependency(CorePlugin.Id)]
public partial class ItemsPlugin : BaseUnityPlugin
{
    internal static ManualLogSource Log { get; private set; } = null!;

    private void Awake()
    {
        Log = Logger;
        MonoDetourManager.InvokeHookInitializers(typeof(ItemsPlugin).Assembly);
        Log.LogInfo($"Plugin {Name} is loaded!");
    }
}
