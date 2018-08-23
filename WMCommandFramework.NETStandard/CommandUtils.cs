﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WMCommandFramework.NETStandard
{
    public class CommandUtils
    {
        private static bool _debug = false;
        private static InputMessage inputMessage = null;
        private static ApplicationVersion _applicationVersion = ApplicationVersion.CommandFrameworkVersion;

        /// <summary>
        /// Whether debug information should be printed to the current terminal.
        /// </summary>
        public static bool DebugMode
        {
            get => _debug;
            set => _debug = value;
        }

        /// <summary>
        /// The message to display in every command input prompt.
        /// </summary>
        public static InputMessage InputMessage
        {
            get => inputMessage;
            set
            {
                if (value != null) inputMessage = value;
            }
        }

        /// <summary>
        /// The version of the current application.
        /// </summary>
        public static ApplicationVersion Version
        {
            get => _applicationVersion;
            set => _applicationVersion = value;
        }
    }
}
