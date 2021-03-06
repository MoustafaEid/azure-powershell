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
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents the Azure SQL capabilities for a region.
    /// </summary>
    public partial class LocationCapability
    {
        private string _name;
        
        /// <summary>
        /// Optional. Gets the region name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Gets the status for the region with respect to Azure SQL.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private IList<ServerVersionCapability> _supportedServerVersions;
        
        /// <summary>
        /// Optional. Gets the list of supported Azure SQL Server versions.
        /// </summary>
        public IList<ServerVersionCapability> SupportedServerVersions
        {
            get { return this._supportedServerVersions; }
            set { this._supportedServerVersions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LocationCapability class.
        /// </summary>
        public LocationCapability()
        {
            this.SupportedServerVersions = new LazyList<ServerVersionCapability>();
        }
    }
}
