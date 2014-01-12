using QuizApp.UI.Models;

namespace QuizApp.UI.ViewModel
{
    public class LoginSignupViewModel
    {
        public RegisterModel RegisterModel { get;  set; }

        public LoginModel LoginModel { get;  set; }

        public ForgotPasswordViewModel ForgotPasswordViewModel { get;  set; }

        public ViewType DisplayViewType { get;  set; }

        public LoginSignupViewModel(ViewType viewType)
        {
            RegisterModel = new RegisterModel();
            LoginModel = new LoginModel();
            ForgotPasswordViewModel = new ForgotPasswordViewModel();
            DisplayViewType = viewType;
        }

        public enum ViewType
        {
            Login=0,
            Register,
            ForgotPassword
        }
    }


}