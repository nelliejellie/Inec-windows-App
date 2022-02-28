using Core.Contracts;
using Core.Services;
using Core.Persistence;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var database = new Database();
            Application.Run(new Form1(new RegisterationService(new VoterRepository(database) ), database));
        }
    }
}
