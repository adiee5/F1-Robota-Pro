﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace F1_Robota_Pro
{
    //string NoFileFlag="§"
    static class SaveMan
    {
        public static string Wczytaj(string nazwa)
        {
            return WczytajPlik(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + $"\\F1 Robota Pro\\{nazwa}.json");
        }
        public static string WczytajPlik(string ścieżka)
        {
            if (!File.Exists(ścieżka)) return null;
            return File.ReadAllText(ścieżka);
        }

        public static void Zapisz(string nazwa,string zawartość)
        {
            ZapiszPlik(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + $"\\F1 Robota Pro\\{nazwa}.json", zawartość);
        }
        public static void ZapiszPlik(string ścieżka,string zawartość)
        {
            //var p = Path.GetDirectoryName(ścieżka);
            if (!Directory.Exists(Path.GetDirectoryName(ścieżka))) Directory.CreateDirectory(Path.GetDirectoryName(ścieżka));
            File.WriteAllText(ścieżka,zawartość);
        }

        public static void Usuń(string nazwa, string zawartość)
        {
            UsuńPlik(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + $"\\F1 Robota Pro\\{nazwa}.json");
        }
        public static void UsuńPlik(string ścieżka)
        {
            File.Delete(ścieżka);
        }

        public static string NameDialog(string nazwa, bool nowy=true)
        {
            var tmp = Path.GetTempFileName();
            new DodajForm(tmp,nazwa,nowy).ShowDialog();
            string h = File.ReadAllText(tmp);
            File.Delete(tmp);
            return h;
        }

    }
}