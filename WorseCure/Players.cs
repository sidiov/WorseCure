using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteMMO.API;

namespace WorseCure3
{
    internal static class Players
    {

        /// <summary>
        /// Find the target ID based on the name
        /// </summary>
        /// <param name="_ELZ">target name</param>
        /// <param name="pc_name">target name</param>
        /// <returns></returns>
        internal static int GetPlayerID(EliteAPI _ELZ, string pc_name)
        {
            //We check the first 2000 entries in the client target list
            for (int i = 0; i <= 2000; i++)
            {
                //logger.Debug("Looking for: " + _ELZ.Entity.GetEntity(i).Name);
                if (string.IsNullOrEmpty(_ELZ.Entity.GetEntity(i).Name)) //_FFACE.NPC.Name(i)))
                {
                    //Exit the loop
                }
                else
                {
                    if (_ELZ.Entity.GetEntity(i).Name == pc_name)
                    {
                        //logger.Info("Found player: " + pc_name + " with ID: " + i);
                        return i;
                    }
                }

            }

            //logger.Warn("Player not found nearby.");
            return 9999;
        }
    }
}
