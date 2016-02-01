
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.BLL
{
    [Serializable()]
    public class ToDoBO
    {
        private string _pealikiri;
        private string _kirjeldus;
        private DateTime _loodud;
        public enum priorideedid { Madal, Keskmine, Kqrge } //0-Madal, 1-Keskmine, 2-Kõrge
        private priorideedid _prioriteet;
        private bool _olek;

        public ToDoBO(string pealkiri, string kirjeldus, DateTime loodud, priorideedid prioriteet, bool _olek)
        {
            this._pealikiri = pealkiri;
            this._kirjeldus = kirjeldus;
            this._loodud = loodud;
            this._prioriteet = prioriteet;
            this._olek = false;
        }

        public bool ifEqual(ToDoBO another) {
            if (this._pealikiri == another.Pealkiri && this.Kirjeldus == another.Kirjeldus && this.Loomiseaeg == another.Loomiseaeg && this.Prioriteet == another.Prioriteet) {
                return true;
            }
            return false;
        }

        public string Pealkiri
        {
            get { return _pealikiri; }
            set { _pealikiri = value; }

        }

        public string Kirjeldus
        {
            get { return _kirjeldus; }
            set { _kirjeldus = value; }
        }

        public DateTime Loomiseaeg
        {
            get { return _loodud; }
            set { _loodud = value; }
        }

        public priorideedid Prioriteet
        {
            get { return _prioriteet; }
            set { _prioriteet = value; }
        }

        public bool Olek
        {
            get { return _olek; }
            set { _olek = value; }
        }

    }
}
