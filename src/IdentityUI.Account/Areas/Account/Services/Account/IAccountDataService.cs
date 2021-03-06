﻿using SSRD.IdentityUI.Account.Areas.Account.Models.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSRD.IdentityUI.Account.Areas.Account.Services.Account
{
    public interface IAccountDataService
    {
        LoginViewModel GetLoginViewModel(string returnUrl);
        RegisterSuccessViewModel GetRegisterSuccessViewModel();
        RegisterViewModel GetRegisterViewModel();
    }
}
