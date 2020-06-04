// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> SSIS package execution log location. </summary>
    public partial class SsisLogLocation
    {
        /// <summary> Initializes a new instance of SsisLogLocation. </summary>
        /// <param name="logPath"> The SSIS package execution log path. Type: string (or Expression with resultType string). </param>
        /// <param name="type"> The type of SSIS log location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logPath"/> is null. </exception>
        public SsisLogLocation(object logPath, SsisLogLocationType type)
        {
            if (logPath == null)
            {
                throw new ArgumentNullException(nameof(logPath));
            }

            LogPath = logPath;
            Type = type;
        }

        /// <summary> Initializes a new instance of SsisLogLocation. </summary>
        /// <param name="logPath"> The SSIS package execution log path. Type: string (or Expression with resultType string). </param>
        /// <param name="type"> The type of SSIS log location. </param>
        /// <param name="accessCredential"> The package execution log access credential. </param>
        /// <param name="logRefreshInterval"> Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        internal SsisLogLocation(object logPath, SsisLogLocationType type, SsisAccessCredential accessCredential, object logRefreshInterval)
        {
            LogPath = logPath;
            Type = type;
            AccessCredential = accessCredential;
            LogRefreshInterval = logRefreshInterval;
        }

        /// <summary> The SSIS package execution log path. Type: string (or Expression with resultType string). </summary>
        public object LogPath { get; set; }
        /// <summary> The type of SSIS log location. </summary>
        public SsisLogLocationType Type { get; set; }
        /// <summary> The package execution log access credential. </summary>
        public SsisAccessCredential AccessCredential { get; set; }
        /// <summary> Specifies the interval to refresh log. The default interval is 5 minutes. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object LogRefreshInterval { get; set; }
    }
}