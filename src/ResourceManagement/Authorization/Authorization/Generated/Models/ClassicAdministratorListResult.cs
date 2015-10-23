// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.Authorization.Models;

namespace Microsoft.Azure.Management.Authorization.Models
{
    /// <summary>
    /// ClassicAdministrator list result information.
    /// </summary>
    public partial class ClassicAdministratorListResult : AzureOperationResponse
    {
        private IList<ClassicAdministrator> _classicAdministrators;
        
        /// <summary>
        /// Optional. Gets or sets ClassicAdministrators.
        /// </summary>
        public IList<ClassicAdministrator> ClassicAdministrators
        {
            get { return this._classicAdministrators; }
            set { this._classicAdministrators = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ClassicAdministratorListResult
        /// class.
        /// </summary>
        public ClassicAdministratorListResult()
        {
            this.ClassicAdministrators = new LazyList<ClassicAdministrator>();
        }
    }
}