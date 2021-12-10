using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace mApp
{                         // TOTO ZATIAL NEFUNGUJE, ALE MAM TO LEN AKO JEDNU Z MOZNOSTI..
    public class User
    {
        public static string userName { get; set; }
        public static void UserName(string user)
        {
            userName = userName + user;
            OnPropertyChanged(userName);
        }

        public static event PropertyChangedEventHandler PropertyChanged;
        private static void OnPropertyChanged([CallerMemberName] string x = null)
        {
            PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(x));
        }
    }
}
