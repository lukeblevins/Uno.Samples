﻿using Windows.ApplicationModel.Resources;

namespace TimeEntryUno.Shared.Helpers
{
    public static class ErrorMessageHelper
    {
        private static ResourceLoader _resourceLoader = ResourceLoader.GetForCurrentView("ErrorMessages");

        public static string GetErrorMessageResource(string name)
        {
            return _resourceLoader.GetString(name);
        }
    }
}
