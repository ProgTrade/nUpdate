﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using nUpdate.Core;
using nUpdate.Core.Operations;

namespace nUpdate.Internal
{
    [Serializable]
    internal class UpdateConfiguration
    {
        /// <summary>
        ///     The literal version of the package.
        /// </summary>
        public string LiteralVersion { get; set; }

        /// <summary>
        ///     Sets if the package should be used within the statistics.
        /// </summary>
        public bool UseStatistics { get; set; }

        /// <summary>
        ///     The url of the PHP-file which redirects to the package download and does the statistic entries.
        /// </summary>
        public Uri UpdatePhpFileUrl { get; set; }

        /// <summary>
        ///     The version ID of this package to use in the statistics, if used.
        /// </summary>
        public int VersionId { get; set; }

        /// <summary>
        ///     The url of the update package.
        /// </summary>
        public Uri UpdatePackageUrl { get; set; }

        /// <summary>
        ///     The whole changelog of the update package.
        /// </summary>
        public Dictionary<CultureInfo, string> Changelog { get; set; }

        /// <summary>
        ///     The signature of the update package (Base64 encoded).
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        ///     The unsupported versions of the update package.
        /// </summary>
        public string[] UnsupportedVersions { get; set; }

        /// <summary>
        ///     The architecture settings of the update package.
        /// </summary>
        public Architecture Architecture { get; set; }

        /// <summary>
        ///     The operations of the update package.
        /// </summary>
        public List<Operation> Operations { get; set; }

        /// <summary>
        ///     Sets if this update must be installed.
        /// </summary>
        public bool MustUpdate { get; set; }

        /// <summary>
        ///     Downloads the update configurations from the server.
        /// </summary>
        /// <param name="configFileUrl">The url of the configuration file.</param>
        /// <param name="proxy">The optional proxy to use.</param>
        /// <returns>Returns an <see cref="IEnumerable"/> of type <see cref="UpdateConfiguration"/> containing the package configurations.</returns>
        public static IEnumerable<UpdateConfiguration> Download(Uri configFileUrl, WebProxy proxy)
        {
            using (var wc = new WebClientWrapper())
            {
                if (proxy != null)
                    wc.Proxy = proxy;

                // Check for SSL and ignore it
                ServicePointManager.ServerCertificateValidationCallback += delegate { return (true); };
                string source = wc.DownloadString(configFileUrl);
                if (!String.IsNullOrEmpty(source))
                    return Serializer.Deserialize<IEnumerable<UpdateConfiguration>>(source);
            }

            return null;
        }

        /// <summary>
        ///     Loads an update configuration from a local file.
        /// </summary>
        /// <param name="filePath">The path of the file.</param>
        public static IEnumerable<UpdateConfiguration> FromFile(string filePath)
        {
            return Serializer.Deserialize<IEnumerable<UpdateConfiguration>>(File.ReadAllText(filePath));
        }
    }
}