using System;

namespace Blog.WPF.Contracts.Services
{
    public interface IApplicationInfoService
    {
        Version GetVersion();
    }
}
