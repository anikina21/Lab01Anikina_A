using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NaUKMA.CSharp2024.Lab01Anikina_A.Models;

namespace NaUKMA.CSharp2024.Lab01Anikina_A.Views
{
    /// <summary>
    /// Interaction logic for BDpick.xaml
    /// </summary>
    public partial class BDpick : UserControl
    {
        private UserBirthday _user = new UserBirthday();

        //public DateTime _bd
        //{
        //    get { return _user.Birthday; }
        //    set
        //    {
        //        _user.Birthday = value;
        //    }
        //}
        //public string _westZ
        //{
        //    get { return _user.Westzodiac.ToString(); }
        //}
        //public string _chinaZ
        //{
        //    get { return _user.Chinazodiac.ToString(); }
        //}

        
        //////////////////////////////////
        
        public DateTime Birthhday
        {
            get
            {
                return (DateTime)BDpicker.SelectedDate;
            }
            set
            {
                BDpicker.SelectedDate = value;
            }
        }
        public string SetdDate
        {
            set
            {
                BDshowing.Text = value;
            }
            get { return BDshowing.Text; }
        }
        private void BDsetter_Click(object sender, RoutedEventArgs e)
        {
            
            if (BDpicker.SelectedDate == null) return;

            var res = (DateTime)BDpicker.SelectedDate;
            if (res.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Error\nHaven't been born yet?");

            } else
            if (DateTime.Now.Year - res.Year > 136)
            {
                MessageBox.Show("Error\nToo old to be true");

            }
            else
            {
                Birthhday = res;
                if(res.Day == DateTime.Now.Day && res.Month == DateTime.Now.Month)
                {
                    MessageBox.Show("HAPPY BIRTHDAY!!!");
                }
                _user.Birthday = res;
                SetdDate = $"Saved birthday: {Birthhday.Date.ToString("dd/MM/yyyy")} || " +
                    $"Age: {_user.Age}";
                WestText.Text = _user.Westzodiac.ToString();
                ChinaText.Text = _user.Chinazodiac.ToString();

            }
        }
        public BDpick()
        {
            InitializeComponent();
        }
    }
}
