using Hospital.SQL;
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
using System.Windows.Shapes;

namespace Hospital.Windows
{
    /// <summary>
    /// Логика взаимодействия для NewPatient.xaml
    /// </summary>
    public partial class NewPatient : Window
    {
        public NewPatient()
        {
            InitializeComponent();

            ComboBoxGender.Items.Add("Мужской");
            ComboBoxGender.Items.Add("Женский");

            ComboBoxGender.Text = "Мужской";

            Load();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            string lastWindows = Param.lastWindow == null ? "" : Param.lastWindow;
            if (lastWindows.Equals("ListPatient"))
            {
                if (Patients.UpdateItem(Param.id,TextBoxFirstName.Text, TextBoxMiddleName.Text, TextBoxLastName.Text, ComboBoxGender.SelectedValue.ToString(), TextBoxPhoneNumber.Text))
                    Close();
            }
            else
            {
                if (Patients.NewItem(TextBoxFirstName.Text, TextBoxMiddleName.Text, TextBoxLastName.Text, ComboBoxGender.SelectedValue.ToString(), TextBoxPhoneNumber.Text))
                    Close();
            }
        }

        private void Load()
        {
            if (Param.lastWindow != null)
                if (Param.lastWindow.Equals("ListPatient"))
                {
                    ButtonAdd.Content = "Обновить"; //change name button

                    using (var db = new AutoDataContext())
                    {
                        var query = from item in db.Patient
                                    orderby item.lastName, item.firstName, item.middleName
                                    where item.id == Param.id
                                    select new
                                    {
                                        id = item.id,
                                        firstName = item.firstName,
                                        lastName = item.lastName,
                                        middleName = item.middleName,
                                        gender = item.gender,
                                        phoneNumber = item.phoneNumber
                                    }
                                   ;

                        var arr = query.ToArray();

                        foreach (var record in arr)
                        {
                            TextBoxFirstName.Text = record.firstName;
                            TextBoxLastName.Text = record.lastName;
                            TextBoxMiddleName.Text = record.middleName;
                            ComboBoxGender.Text = record.gender;
                            TextBoxPhoneNumber.Text = record.phoneNumber;
                        }
                    }
                }
        }

    }
}
