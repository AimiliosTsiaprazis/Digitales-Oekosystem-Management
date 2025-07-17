using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace VorbereitungIHK
{
    class EnvironmentParameters
    {
        private int _temperatur;
        private int _luftfeuchtigkeit;
        private int _phWert;
        private int _lichtintensitaet;
        public EnvironmentParameters(int _temperatur, int _luftfeuchtigkeit, int _phWert, int _lichtintensitaet)
        {
            this._temperatur = _temperatur;
            this._luftfeuchtigkeit = _luftfeuchtigkeit;
            this._phWert = _phWert;
            this._lichtintensitaet = _lichtintensitaet;
        }
        public int Temperatur
        {
            get { return this._temperatur; }
            set { this._temperatur = value; }
        }
        public int Luftfeuchtigkeit
        {
            get { return this._luftfeuchtigkeit; }
            set { this._luftfeuchtigkeit = value; }
        }
        public int PhWert
        {
            get { return this._phWert; }
            set { this._phWert = value; }
        }
        public int Lichtintensitaet
        {
            get { return this._lichtintensitaet; }
            set { this._lichtintensitaet = value; }
        }
    }
}