using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeatDownloaderLib.Core
{
    public class GamePathManager
    {

        public const string beatSaberAppID = "620980";

        public string GetSteamPath()
        {
            string thirdyTwoBitKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam";
            string sixtyFourBitKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam";

            // Try and get values for both key paths
            string thirdyTwoBitSteamPath = "";
            string sixtyFourBitSteamPath = "";
            try
            {
                thirdyTwoBitSteamPath = (string)Registry.GetValue(thirdyTwoBitKey, "InstallPath", null);
                sixtyFourBitSteamPath = (string)Registry.GetValue(sixtyFourBitKey, "InstallPath", null);

                if (!(thirdyTwoBitSteamPath == null))
                {
                    return thirdyTwoBitSteamPath;
                }
                else if (!(sixtyFourBitSteamPath == null))
                {
                    return sixtyFourBitSteamPath;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return "";
        }

        public string GetGamePath()
        {
            string key = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App " + beatSaberAppID;

            try
            {
                return (string) Registry.GetValue(key, "InstallLocation", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
