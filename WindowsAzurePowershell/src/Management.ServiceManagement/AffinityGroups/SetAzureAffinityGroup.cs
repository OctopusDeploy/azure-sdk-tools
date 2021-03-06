﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.ServiceManagement.AffinityGroups
{
    using System.Management.Automation;
    using Cmdlets.Common;
    using Management.Model;
    using Microsoft.WindowsAzure.Management.Utilities;
    using WindowsAzure.ServiceManagement;

    /// <summary>
    /// Updates the label and/or the description for an affinity group for the specified subscription.
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "AzureAffinityGroup"), OutputType(typeof(ManagementOperationContext))]
    public class SetAzureAffinityGroup : ServiceManagementBaseCmdlet
    {
        public SetAzureAffinityGroup()
        {
        }

        public SetAzureAffinityGroup(IServiceManagement channel)
        {
            Channel = channel;
        }

        /// <summary>
        /// The name for the affinity group. (Required)
        /// </summary>
        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "Name of the affinity group.")]
        [ValidateNotNullOrEmpty]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// A label for the affinity group. The label may be up to 100 characters in length. (Required)
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Label of the affinity group.")]
        [ValidateNotNullOrEmpty]
        [ValidateLength(1, 100)]
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// A description for the affinity group. The description may be up to 1024 characters in length. (Optional)
        /// </summary>
        [Parameter(HelpMessage = "Description of the affinity group.")]
        [ValidateLength(0, 1024)]
        public string Description
        {
            get;
            set;
        }

        internal void ExecuteCommand()
        {

            var upaginput = new UpdateAffinityGroupInput
            {
                Label = ServiceManagementHelper.EncodeToBase64String(this.Label),
                Description = this.Description ?? null
            };

            ExecuteClientActionInOCS(upaginput, CommandRuntime.ToString(), s => this.Channel.UpdateAffinityGroup(s, this.Name, upaginput), WaitForOperation);
        }

        protected override void OnProcessRecord()
        {
            this.ExecuteCommand();
        }

    }
}
