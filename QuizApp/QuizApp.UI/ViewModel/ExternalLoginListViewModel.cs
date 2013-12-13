#region File Header
// /******************************************************************************
//  * 
//  *      Copyright (C) Siemens 2013 All Rights Reserved. Confidential
//  * 
//  ******************************************************************************
//  * 
//  *      Project:        QuizApp
//  *      SubProject:     QuizApp.UI
//  *      Author:         Dave Ankesh IN PUN STS
//  *      Created On:     13-12-2013 4:26 PM
//  *      Modified On:    13-12-2013 4:26 PM
//  *      FileName:       ExternalLoginListViewModel.cs
//  * 
//  *****************************************************************************/
#endregion

using System.Collections.Generic;
using System.Linq;

using Microsoft.Web.WebPages.OAuth;

namespace QuizApp.UI.ViewModel
{
    public class ExternalLoginListViewModel : List<ExternalLoginViewModel>
    {
        public IList<ExternalLoginViewModel> CreateExternalLoginList ( ICollection<AuthenticationClientData> authenticationClientCollection )
        {
            foreach (AuthenticationClientData authenticationClientData in authenticationClientCollection)
            {
                var externalLogin = new ExternalLoginViewModel();
                var data = GetSettings(authenticationClientData.AuthenticationClient.ProviderName);
                externalLogin.AuthenticationClientData = authenticationClientData;
                externalLogin.ContainerCssClass = data.ContainerCssClass;
                externalLogin.ContainerCssStyle = data.ContainerCssStyle;
                externalLogin.IconCssClass = data.IconCssClass;
                this.Add(externalLogin);
            }
            return this;
        }

        /// <summary>
        /// Get CSS Specific Settings for Different Auth Providers fro Display
        /// </summary>
        /// <param name="providerName"></param>
        /// <returns></returns>
        private dynamic GetSettings(string providerName)
        {
            switch (providerName)
            {
                case "Google":
                    return new { ContainerCssClass = @"", ContainerCssStyle = @"", IconCssClass = @"iconSocial-google" };
                case "Facebook":
                    return new { ContainerCssClass = "", ContainerCssStyle = "", IconCssClass = "" };
                case "Microsoft":
                    return new { ContainerCssClass = "", ContainerCssStyle = "", IconCssClass = "" };
                case "Twitter":
                    return new { ContainerCssClass = "", ContainerCssStyle = "", IconCssClass = "" };
                default:
                    return new { ContainerCssClass = "", ContainerCssStyle = "", IconCssClass = "" };
            }
        }
    }
}

#region Copyright (C) Siemens AG 2013

/*************************************************************************************************************
 * 
 *      Copyright (C) Siemens AG 2013 All Rights Reserved. Confidential
 *
 * ***********************************************************************************************************/

#endregion