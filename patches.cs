using HarmonyLib;
using StardewModdingAPI;
using StardewValley;
using System.Collections.Generic;
using System.Drawing;

namespace SouthernShores
{
    public class Patches
    {
        public static void parseMasterSchedule_postfix(string rawData, string previousGameLocation, ref Point previousPosition)
        {
            {
                if (previousPosition == new Point(0, 23))
                {
                    int x = 0; // replace with your desired value for x
                    int y = 20; // replace with your desired value for y
                    previousPosition.X = x;
                    previousPosition.Y = y;
                    string newLocation = "Town"; // replace with your desired value for x
                    _ = previousGameLocation == newLocation;

                }
            }
        }
    }
}
