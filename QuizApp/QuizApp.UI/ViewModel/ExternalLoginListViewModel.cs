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
        public IList<ExternalLoginViewModel> CreateExternalLoginList ( IList<AuthenticationClientData> authenticationClientCollection )
        {
            foreach (AuthenticationClientData authenticationClientData in authenticationClientCollection)
            {
                var externalLogin = new ExternalLoginViewModel();
                var data = GetSettings(authenticationClientData.DisplayName);
                externalLogin.AuthenticationClientData = authenticationClientData;
                externalLogin.AnchorCssClass = data.AnchorCssClass;
                externalLogin.AnchorCssStyle = data.AnchorCssStyle;
                externalLogin.DivCssClass = data.DivCssClass;
                externalLogin.DivCssStyle = data.DivCssStyle;
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
                    return new { AnchorCssClass = @"swidget", AnchorCssStyle = @"background: #e04d38 !important; height: 100px; width: 100px", DivCssClass = @"value", DivCssStyle = @"font-size: 72px;", IconCssClass = @"ico-google" };
                case "Facebook":
                    return new { AnchorCssClass = @"swidget", AnchorCssStyle = @"background: #3b5999 !important; height: 100px; width: 100px", DivCssClass = @"value", DivCssStyle = @"font-size: 72px;", IconCssClass = "ico-facebook" };
                case "Microsoft":
                    return new { AnchorCssClass = @"swidget", AnchorCssStyle = @"background: #00acee !important; height: 100px; width: 100px", DivCssClass = @"value", DivCssStyle = @"font-size: 72px;", IconCssClass = "ico-twitter" };
                case "Twitter":
                    return new { AnchorCssClass = @"swidget", AnchorCssStyle = @"background: #00A600 !important; height: 100px; width: 100px", DivCssClass = @"value", DivCssStyle = @"font-size: 72px;", IconCssClass = "ico-windows8" };
                case"Yahoo":
                    return new { AnchorCssClass = @"swidget", AnchorCssStyle = @"background: #720e9e !important; height: 100px; width: 100px", DivCssClass = @"value", DivCssStyle = @"font-size: 72px;", IconCssClass = "ico-yahoo" };
                default:
                    return new { AnchorCssClass = @"swidget", AnchorCssStyle = @"background: #000080 !important; height: 100px; width: 100px", DivCssClass = @"value", DivCssStyle = @"font-size: 72px;", IconCssClass = "ico-group" };
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