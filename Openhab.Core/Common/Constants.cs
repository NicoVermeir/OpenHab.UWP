﻿namespace OpenHAB.Core.Common
{
    /// <summary>
    /// A class that holds all the constants for the app
    /// </summary>
    public sealed class Constants
    {
        /// <summary>
        /// Holds the constants that are used for in-app stuff
        /// </summary>
        public sealed class Local
        {
            /// <summary>
            /// The key that is used to persist settings to the Windows settings store
            /// </summary>
            public const string SettingsKey = "UserSettingsKey";
        }

        /// <summary>
        /// Holds the constants used in server calls
        /// </summary>
        public sealed class Api
        {
            /// <summary>
            /// Url used for Demo mode
            /// </summary>
            public const string DemoModeUrl = "http://demo.openhab.org:8080/";

            /// <summary>
            /// The call to determine the OpenHAB version
            /// </summary>
            public const string ServerVersion = "rest/bindings";

            /// <summary>
            /// The call to fetch the sitemaps
            /// </summary>
            public const string Sitemaps = "rest/sitemaps";

            /// <summary>
            /// The call to get an event-stream
            /// </summary>
            public const string Events = "rest/events";
        }
    }
}
