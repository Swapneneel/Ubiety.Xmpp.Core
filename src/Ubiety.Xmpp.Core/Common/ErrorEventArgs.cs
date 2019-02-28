﻿// Copyright 2018 Dieter Lunn
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System;
using Ubiety.Xmpp.Core.Tags.Stream;

namespace Ubiety.Xmpp.Core.Common
{
    /// <summary>
    ///     Event args for an error
    /// </summary>
    public class ErrorEventArgs : EventArgs
    {
        /// <summary>
        ///     Gets or sets the error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the stream error
        /// </summary>
        public Error StreamError { get; set; }
    }
}
