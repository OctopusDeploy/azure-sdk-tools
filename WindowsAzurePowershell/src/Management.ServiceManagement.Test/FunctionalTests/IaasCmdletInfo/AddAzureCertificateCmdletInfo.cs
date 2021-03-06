// ----------------------------------------------------------------------------------
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
    using System.Management.Automation;

    public class AddAzureCertificateCmdletInfo : CmdletsInfo
    {
        public AddAzureCertificateCmdletInfo(string serviceName, PSObject cert, string password)
        {
            cmdletName = Utilities.AddAzureCertificateCmdletName;
                        
            cmdletParams.Add(new CmdletParam("ServiceName", serviceName));            
            cmdletParams.Add(new CmdletParam("CertToDeploy", cert));
            if (password != null)
            {
                cmdletParams.Add(new CmdletParam("Password", password));
            }            
        }
    }
}
