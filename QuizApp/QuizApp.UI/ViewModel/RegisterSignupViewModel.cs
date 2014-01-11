using QuizApp.UI.Models;

namespace QuizApp.UI.ViewModel
{
    public class RegisterSignupViewModel
    {
        public RegisterModel RegisterModel { get;  set; }

        public LoginModel LoginModel { get;  set; }

        public ForgotPasswordViewModel ForgotPasswordViewModel { get;  set; }

        public RegisterSignupViewModel()
        {
            RegisterModel = new RegisterModel();
            LoginModel = new LoginModel();
            ForgotPasswordViewModel = new ForgotPasswordViewModel();
        }
    }
}