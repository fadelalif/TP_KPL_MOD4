using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302210059.TPMOD4
{
    class KodePos
    {
        private Dictionary<string, string> kodepos = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

        public string getKodePos(string kelurahan)
        {
            if (kodepos.ContainsKey(kelurahan))
            {
                return "Kode posnya adalah: " + kodepos[kelurahan];
            }
            else
            {
                return "Kode pos tidak ditemukan";
            }
        }
    }
}
