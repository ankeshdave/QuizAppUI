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
//  *      Created On:     13-12-2013 4:21 PM
//  *      Modified On:    13-12-2013 4:21 PM
//  *      FileName:       ExternalLoginViewModel.cs
//  * 
//  *****************************************************************************/
#endregion

using Microsoft.Web.WebPages.OAuth;

namespace QuizApp.UI.ViewModel
{
    public class ExternalLoginViewModel
    {
        public string AnchorCssClass { get; set; }

        public string AnchorCssStyle { get; set; }

        public string DivCssClass { get; set; }
        public string DivCssStyle { get; set; }

        public string IconCssClass { get; set; }

        public AuthenticationClientData AuthenticationClientData { get; set; }
    }
}

#region Copyright (C) Siemens AG 2013

/*************************************************************************************************************
 * 
 *      Copyright (C) Siemens AG 2013 All Rights Reserved. Confidential
 *
 * ***********************************************************************************************************/

#endregion