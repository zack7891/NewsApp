﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewsApp.ViewModels
{
    public interface INavigate
    {
        Task NavigateTo(string route);
        Task PushModal(Page page);
        Task PopModal();
    }
}
