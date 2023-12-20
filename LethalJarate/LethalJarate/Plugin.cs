using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Logging;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace LethalJarate
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class LethalJarateModBase : BaseUnityPlugin
    {
        public const string modGUID = "Starman_x64.LethalJarate";
        public const string modName = "Lethal Jarate";
        public const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static LethalJarateModBase Instance;

        public static ManualLogSource mls;

        //public static AssetBundle assetBundle;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            //assetBundle = AssetBundle.LoadFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "IshiharaCompany/ishiharacompany"));

            mls.LogInfo("Plugin " + modName + " is loaded!");

            harmony.PatchAll(typeof(LethalJarateModBase));
        }
    }
}
