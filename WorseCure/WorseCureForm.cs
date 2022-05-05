using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
//using NLog;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using EliteMMO.API;

namespace WorseCure3
{
    public partial class WorseCureForm : Form
    {
        #region Objects
        public EliteAPI _ELZ { get; set; }
        public int pid = 0;
        #endregion

        public WorseCureForm()
        {
            InitializeComponent();
            
            _ELZ = SetChars();
            pid = Players.GetPlayerID(_ELZ, _ELZ.Player.Name);
        }

        /// <summary>
        /// Select the POL instance
        /// </summary>
        /// <returns></returns>
        internal EliteAPI SetChars()
        {
            Process[] pol = Process.GetProcessesByName("pol");
            int atc_pid = -1;

            //make sure pol is running
            if (pol.Length < 1)
            {
                //let the user know what went wrong
                //logger.Error("FFXI instance not found.");
                MessageBox.Show("FFXI not found");
                System.Environment.Exit(0);     //close the form
            }
            else if (pol.Length == 1)
            {
                //create the instance using the first pol process found
                atc_pid = 0;
                //logger.Info("FFXI instance: " + pol[0].Id.ToString());
                return new EliteAPI(pol[atc_pid].Id);
            }
            else if (pol.Length > 1)
            {

                //logger.Debug("Multiple FFXI instances found, launching selector.");
                using (POLSelect selector = new POLSelect())
                {
                    selector.ShowDialog();
                    atc_pid = selector.SelectedPID;
                }
                if (atc_pid == -1)
                {
                    //let the user know what went wrong
                    //logger.Error("FFXI instance not found.");
                    MessageBox.Show("FFXI not found");
                    System.Environment.Exit(0);     //close the form
                }

                return new EliteAPI(atc_pid);
            }

            return null;

        }

        #region FormObjects
        private void b_Start_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }

}
