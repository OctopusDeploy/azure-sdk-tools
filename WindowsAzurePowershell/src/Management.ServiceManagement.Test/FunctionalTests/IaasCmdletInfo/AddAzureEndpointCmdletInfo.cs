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

namespace Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.IaasCmdletInfo
{
    using Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.PowershellCore;
    using Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.ConfigDataInfo;

    public class AddAzureEndpointCmdletInfo : CmdletsInfo
    {
        public static AddAzureEndpointCmdletInfo BuildNoLoadBalancedCmdletInfo(AzureEndPointConfigInfo endPointConfig)
        {
            var result = new AddAzureEndpointCmdletInfo();

            result.cmdletParams.Add(new CmdletParam("Name", endPointConfig.EndpointName));
            result.cmdletParams.Add(new CmdletParam("LocalPort", endPointConfig.InternalPort));
            result.cmdletParams.Add(new CmdletParam("PublicPort", endPointConfig.ExternalPort));
            result.cmdletParams.Add(new CmdletParam("Protocol", endPointConfig.Protocol.ToString()));
            result.cmdletParams.Add(new CmdletParam("VM", endPointConfig.Vm));
            return result;
        }

        public AddAzureEndpointCmdletInfo()
        {
            this.cmdletName = Utilities.AddAzureEndpointCmdletName;
        }

        public AddAzureEndpointCmdletInfo(AzureEndPointConfigInfo endPointConfig)
        {
            this.cmdletName = Utilities.AddAzureEndpointCmdletName;

            this.cmdletParams.Add(new CmdletParam("Name", endPointConfig.EndpointName)); 
            this.cmdletParams.Add(new CmdletParam("LocalPort", endPointConfig.InternalPort)); //
            this.cmdletParams.Add(new CmdletParam("PublicPort", endPointConfig.ExternalPort)); //
            this.cmdletParams.Add(new CmdletParam("Protocol", endPointConfig.Protocol.ToString())); //
            this.cmdletParams.Add(new CmdletParam("LBSetName", endPointConfig.LBSetName));
            this.cmdletParams.Add(new CmdletParam("ProbePort", endPointConfig.ProbePort)); //
            this.cmdletParams.Add(new CmdletParam("ProbeProtocol", endPointConfig.ProbeProtocol.ToString())); //
            this.cmdletParams.Add(new CmdletParam("ProbePath", endPointConfig.ProbePath)); //
            this.cmdletParams.Add(new CmdletParam("VM", endPointConfig.Vm)); //
        }
    }
}
