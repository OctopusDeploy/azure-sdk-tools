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

using System.Collections.ObjectModel;
using System.Management.Automation;
using Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.IaasCmdletInfo;
using Microsoft.WindowsAzure.Management.Storage.Blob.Context;
namespace Microsoft.WindowsAzure.Management.Storage.Test
{
    public class StorageCmdletTestHelper
    {
        public CopyAzureStorageBlobContext CopyAzureStorageBlob(string source, string destination, bool overwrite)
        {
            var copyAzureBlobCmdletInfo = new CopyAzureBlobCmdletInfo(source, destination, overwrite);
            var azurePowershellCmdlet = new WindowsAzurePowershellCmdlet(copyAzureBlobCmdletInfo);
            Collection<PSObject> result = azurePowershellCmdlet.Run();
            if (result.Count == 1)
            {
                return (CopyAzureStorageBlobContext)result[0].BaseObject;
            }

            return null;
        }
    }
}
