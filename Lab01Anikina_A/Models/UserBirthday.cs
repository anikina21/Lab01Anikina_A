using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaUKMA.CSharp2024.Lab01Anikina_A.Models
{
    #region enums
    enum WesternZodiac
    {
        Aquarius = 1,
        Pieces,
        Aries,
        Taurus,
        Gemini,
        Cancer,
        Leo,
        Virgo,
        Libra,
        Scorpio,
        Sagittarius,
        Capricorn
    }

    enum ChineseZodiac
    {
        Monkey = 0,
        Rooster,
        Dog,
        Pig,
        Rat,
        Ox,
        Tiger,
        Rabbit,
        Dragon,
        Snake,
        Horse,
        Sheep
    }
    #endregion
    internal class UserBirthday
    {
        private DateTime _birthday;
        private int _age;
        private WesternZodiac _westzodiac;
        private ChineseZodiac _chinazodiac;

        public int Age 
        { 
            get { return _age; }
            set {  _age = value; }
        }
        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
                _age = FindAge();
                findChinazodiac();
                findWestZodiac();
            }
        }
        public WesternZodiac Westzodiac
        {
            get { return _westzodiac; }
            set { _westzodiac = value; }
        }
        public ChineseZodiac Chinazodiac
        {
            get { return _chinazodiac; }
            set { _chinazodiac = value; }
        }

        public int FindAge()
        {
            int age = DateTime.Today.Year - Birthday.Year;
            if (Birthday.Date > DateTime.Today.AddYears(-age)) age--;
            return age;
        }

        #region findingZodiac
        public void findChinazodiac()
        {
            if (Birthday.Month == 1)
            {
                if (Birthday.Year % 12 != 0) Chinazodiac = (ChineseZodiac)(Birthday.Year % 12 - 1);
                else Chinazodiac = (ChineseZodiac)12;
            }
            else Chinazodiac = (ChineseZodiac)(Birthday.Year % 12);
        }
        public void findWestZodiac()
        {
            int m = Birthday.Month;
            int d = Birthday.Day;
            switch (m)
            {
                case 1:
                    if (d < 21) Westzodiac = (WesternZodiac)12;
                    else Westzodiac = (WesternZodiac)1;
                    break;
                case 2:
                    if (d < 20) Westzodiac = (WesternZodiac)1;
                    else Westzodiac = (WesternZodiac)2;
                    break;
                case 3:
                    if (d < 21) Westzodiac = (WesternZodiac)2;
                    else Westzodiac = (WesternZodiac)3;
                    break;
                case 4:
                    if (d < 21) Westzodiac = (WesternZodiac)3;
                    else Westzodiac = (WesternZodiac)4;
                    break;
                case 5:
                    if (d < 22) Westzodiac = (WesternZodiac)4;
                    else Westzodiac = (WesternZodiac)5;
                    break;
                case 6:
                    if (d < 22) Westzodiac = (WesternZodiac)5;
                    else Westzodiac = (WesternZodiac)6;
                    break;
                case 7:
                    if (d < 24) Westzodiac = (WesternZodiac)6;
                    else Westzodiac = (WesternZodiac)7;
                    break;
                case 8:
                    if (d < 24) Westzodiac = (WesternZodiac)7;
                    else Westzodiac = (WesternZodiac)8;
                    break;
                case 9:
                    if (d < 24) Westzodiac = (WesternZodiac)8;
                    else Westzodiac = (WesternZodiac)9;
                    break;
                case 10:
                    if (d < 24) Westzodiac = (WesternZodiac)9;
                    else Westzodiac = (WesternZodiac)10;
                    break;
                case 11:
                    if (d < 23) Westzodiac = (WesternZodiac)10;
                    else Westzodiac = (WesternZodiac)11;
                    break;
                case 12:
                    if (d < 26) Westzodiac = (WesternZodiac)11;
                    else Westzodiac = (WesternZodiac)12;
                    break;
            }
        }

        #endregion
    }
}
