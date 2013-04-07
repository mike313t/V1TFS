﻿using System.Security.Policy;
using VersionOne.TFS2010.DataLayer.Interfaces;
using VersionOneTFSServer.Adapters;
using VersionOneTFSServer.Interfaces;

namespace VersionOneTFSServer.Providers
{

    public class ConfigurationProvider : IConfigurationProvider
    {
        public bool Integrated { get; private set; }
        public Url V1Url { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public IProxyConnectionSettings ProxySettings { get; private set; }

        public void ResetDefaults()
        {
            WebConfigurationAdapter.ClearV1Settings();
        }
    }
}