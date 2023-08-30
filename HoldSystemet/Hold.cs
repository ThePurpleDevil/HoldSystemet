using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoldSystemet
{
    public class Hold
    {
        public string Uddannelse { get; private set; }
        public string Lokation { get; private set; }
        public string Betegnelse { get; private set; }
        public int Årgang { get; private set; }
        public bool VinterOptag { get; private set; }

        public Hold(string uddannelse, string lokation, string betengelse, int årgang, bool vinterOptag)
        { 
            Uddannelse= uddannelse;
            Lokation= lokation;
            Betegnelse= betengelse;
            Årgang = årgang;
            VinterOptag = vinterOptag;
            vinterOptag = true;
            _hold = new Dictionary<int, Studerende>();
        }
        Dictionary<int, Studerende> _hold;
        List<int> TilladBetgnelse = new List<int>() { 1,2,3} ;
        public Hold(string betengelse)
        {
            _hold = new Dictionary<int, Studerende>();
            Betegnelse= betengelse;
        }
        public void adderStuderende(Studerende studerende)
        {
            if (!_hold.ContainsKey(studerende.ID))
            {
                _hold.Add(studerende.ID, studerende);
            }
        }

        public void PrintStuderende()
        {
            foreach (Studerende studerende in _hold.Values) 
            {
                Console.WriteLine(studerende);
            }
        }

        public void FjernStuderende(Studerende studerende)
        {
            if (_hold.ContainsKey(studerende.ID))
            {
                _hold.Remove(studerende.ID);
            }
        }
        public bool Ledigstuden(Studerende studerende)
        {
            foreach (Studerende stu in _hold.Values)
            {
                if (stu.ID ==studerende.ID)
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            return $"Uddannelse: {Uddannelse}, Lokation: {Lokation}, Betegnelse: {Betegnelse}, Årgang: {Årgang}, Vinteroptag: {VinterOptag}";
        }
    }
}
