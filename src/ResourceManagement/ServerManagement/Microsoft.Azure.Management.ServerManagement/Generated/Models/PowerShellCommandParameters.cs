// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// the parameters to a powershell script execution command
    /// </summary>
    [JsonTransformation]
    public partial class PowerShellCommandParameters
    {
        /// <summary>
        /// Initializes a new instance of the PowerShellCommandParameters
        /// class.
        /// </summary>
        public PowerShellCommandParameters() { }

        /// <summary>
        /// Initializes a new instance of the PowerShellCommandParameters
        /// class.
        /// </summary>
        public PowerShellCommandParameters(string command = default(string))
        {
            Command = command;
        }

        /// <summary>
        /// Script to execute
        /// </summary>
        [JsonProperty(PropertyName = "properties.command")]
        public string Command { get; set; }

    }
}
