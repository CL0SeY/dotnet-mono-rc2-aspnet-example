using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_mono_rc2_aspnet_example.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
