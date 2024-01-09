﻿using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using LethalParrying.Netcode;
using LethalParrying.Patches;
using System.Reflection;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

namespace LethalParrying
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Lethal Company.exe")]
   
    public class LethalParryBase : BaseUnityPlugin
    {
        // Initialize variables.
        public static LethalParryBase instance;
        public static ManualLogSource logger;
        public static bool serverModCheck = true;
        public static bool stun = false;
        internal static ConfigEntry<int> DropProbability;
        internal static ConfigEntry<bool> Notify;
        internal static ConfigEntry<bool> DisplayCooldown;
        internal static ConfigEntry<float> ParryWindow;
        internal static ConfigEntry<float> ParryCooldown;
        internal static ConfigEntry<string> Keybind;
        private readonly Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
        // Taken from: [https://github.com/EvaisaDev/UnityNetcodeWeaver]
        private void NetCodeWeaver()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                foreach (var method in methods)
                {
                    var attributes = method.GetCustomAttributes(typeof(RuntimeInitializeOnLoadMethodAttribute), false);
                    if (attributes.Length > 0)
                    {
                        method.Invoke(null, null);
                    }
                }
            }
        }

        private void Awake()
        {
            // Initialize Config file. 
            DropProbability = Config.Bind("General", "Drop chance", 15, "Probability for how often you might drop your weapon when failing to parry or holding R.");
            ParryWindow = Config.Bind("General", "Parry Window", 0.25f, "Time for parry window.");
            ParryCooldown = Config.Bind("General", "Parry Cooldown", 2.0f, "Time for parry cooldown.");
            Keybind = Config.Bind("General", "Parry Keybind", "f", "Keybind to trigger parry.");
            Notify = Config.Bind("Screen Information", "Display Parry Notifications", false, "Enables/Disables screen notifications for parry information. (Will be removed when sounds and effects are added)");
            DisplayCooldown = Config.Bind("Screen Information", "Display Parry Cooldown (Notification)", true, "Will show you a notification if your parry is on cooldown. (Display Parry Notifications does not affect this.)");

            if(DropProbability.Value < (int)DropProbability.DefaultValue)
            {
                DropProbability.Value = (int)DropProbability.DefaultValue;
            }
            // For RPC.
            NetCodeWeaver();
            // Set instance to this.
            if (instance == null)
            {
                instance = this;
                logger = Logger;
            }
            // Plugin startup logic
            logger.LogInfo($"---[Only skill issue can kill you now..]---");
            logger.LogInfo($"---[Plugin {PluginInfo.PLUGIN_GUID} is loaded!]---");
            logger.LogInfo($"---[Only skill issue can kill you now..]---");
            harmony.PatchAll(typeof(LethalParryBase)); // Not sure if I need to do this. I'll do it anyways doe
            harmony.PatchAll(typeof(PlayerControllerBPatch));
            harmony.PatchAll(typeof(ShovelPatch));
            //harmony.PatchAll(typeof(ServerModCheck));
        }
    }
}
