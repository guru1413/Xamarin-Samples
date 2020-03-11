using System;
using System.Collections.Generic;
using System.Text;

namespace SamplesApp.Helpers
{
    public static class Constants
    {
        public const string ALERT = "Alert";
        public const string PASSWORD_ERROR_MESSAGE = "Password required";
        public const string EMAIL_ERROR_MESSAGE = "Valid email id required";
        public const string OK = "OK";
        public const string SUCCESS = "Success";
        public const string LOGIN_SUCCESS_MESSAGE = "Login successful";
        public const string EMAIL_REGEX = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
    }
}
