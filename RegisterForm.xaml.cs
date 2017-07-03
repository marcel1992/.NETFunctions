using System;
using System.Windows;
using Xceed.Wpf.Toolkit;

namespace TestMetroFramework.View
{
    /// <summary>
    /// Interaction logic for RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : ChildWindow
    {
        public RegisterForm()
        {
            InitializeComponent();
            RegisterEnable = false;
        }

        #region Dependency Properties
        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(RegisterForm), new PropertyMetadata(null, FirstNameChanged));
        public static readonly DependencyProperty SurnameProperty =
            DependencyProperty.Register("Surname", typeof(string), typeof(RegisterForm), new PropertyMetadata(null, SurnameChanged));
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(RegisterForm), new PropertyMetadata(null, UsernameChanged));
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(RegisterForm), new PropertyMetadata(null, PasswordChanged));

        #endregion

        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }
        private static void FirstNameChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var registerForm = sender as RegisterForm;
            if (registerForm.FirstName.Length > 6)
                registerForm.RegisterEnable = false;

        }
        public string Surname
        {
            get { return (string)GetValue(SurnameProperty); }
            set { SetValue(SurnameProperty, value); }
        }
        private static void SurnameChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var registerForm = sender as RegisterForm;
        }
        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }
        private static void UsernameChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var loginForm = sender as RegisterForm;       
        }
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
        private static void PasswordChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var loginForm = sender as RegisterForm;          
        }



        public bool RegisterEnable
        {
            get { return (bool)GetValue(RegisterEnableProperty); }
            set { SetValue(RegisterEnableProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RegisterEnable.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RegisterEnableProperty =
            DependencyProperty.Register("RegisterEnable", typeof(bool), typeof(RegisterForm), new PropertyMetadata(false));




    }
}
