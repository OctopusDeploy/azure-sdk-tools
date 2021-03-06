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

namespace Microsoft.WindowsAzure.Management.CloudService.Test.Tests.Model
{
    using System;
    using CloudService.Model;
    using Extensions;
    using Management.Services;
    using Management.Test.Stubs;
    using Microsoft.WindowsAzure.Management.Utilities;
    using TestData;
    using Utilities;
    using VisualStudio.TestTools.UnitTesting;
    using ManagementTesting = Microsoft.WindowsAzure.Management.Test.Tests.Utilities.Testing;
    using TestBase = Microsoft.WindowsAzure.Management.Test.Tests.Utilities.TestBase;

    [TestClass]
    public class ServiceSettingsTests : TestBase
    {
        [TestInitialize]
        public void SetupTest()
        {
            GlobalPathInfo.GlobalSettingsDirectory = Data.AzureSdkAppDir;
            CmdletSubscriptionExtensions.SessionManager = new InMemorySessionManager();
        }

        [TestMethod]
        public void ServiceSettingsTest()
        {


            ServiceSettings settings = new ServiceSettings();
            AzureAssert.AreEqualServiceSettings(string.Empty, string.Empty, string.Empty, string.Empty, settings);
        }

        /// <summary>
        /// Verify that using an invalid storage account name throws an
        /// exception.
        /// </summary>
        [TestMethod]
        public void InvalidStorageAccountName()
        {
            // Create a temp directory that we'll use to "publish" our service
            using (FileSystemHelper files = new FileSystemHelper(this) { EnableMonitoring = true })
            {
                // Import our default publish settings
                files.CreateAzureSdkDirectoryAndImportPublishSettings();

                string serviceName = null;
                ManagementTesting.AssertThrows<ArgumentException>(() =>
                    ServiceSettings.LoadDefault(null, null, null, null, null, "I HAVE INVALID CHARACTERS !@#$%", null, null, out serviceName));
                ManagementTesting.AssertThrows<ArgumentException>(() =>
                    ServiceSettings.LoadDefault(null, null, null, null, null, "ihavevalidcharsbutimjustwaytooooooooooooooooooooooooooooooooooooooooolong", null, null, out serviceName));
            }
        }

        /// <summary>
        /// Verify that a service name with invalid characters is correctly
        /// sanitized to a storage account name.
        /// </summary>
        [TestMethod]
        public void SanitizeServiceNameForStorageAccountName()
        {
            // Create a temp directory that we'll use to "publish" our service
            using (FileSystemHelper files = new FileSystemHelper(this) { EnableMonitoring = true })
            {
                // Import our default publish settings
                files.CreateAzureSdkDirectoryAndImportPublishSettings();

                string serviceName = null;
                ServiceSettings settings = ServiceSettings.LoadDefault(null, null, null, null, null, null, "My-Custom-Service!", null, out serviceName);
                Assert.AreEqual("myx2dcustomx2dservicex21", settings.StorageAccountName);

                settings = ServiceSettings.LoadDefault(null, null, null, null, null, null, "MyCustomServiceIsWayTooooooooooooooooooooooooLong", null, out serviceName);
                Assert.AreEqual("mycustomserviceiswaytooo", settings.StorageAccountName);
            }
        }

        /// <summary>
        /// Verify if the location of the storage account is West US or East US in case that no user provided locations.
        /// </summary>
        [TestMethod]
        public void GetDefaultLocationWithWithRandomLocation()
        {
            // Create a temp directory that we'll use to "publish" our service
            using (FileSystemHelper files = new FileSystemHelper(this) { EnableMonitoring = true })
            {
                // Import our default publish settings
                files.CreateAzureSdkDirectoryAndImportPublishSettings();
                string serviceName = null;

                ServiceSettings settings = ServiceSettings.LoadDefault(null, null, null, null, null, null, "My-Custom-Service!", null, out serviceName);
                Assert.IsTrue(settings.Location.Equals(ArgumentConstants.Locations[LocationName.WestUS]) || 
                    settings.Location.Equals(ArgumentConstants.Locations[LocationName.EastUS]));
                
            }
        }

        /// <summary>
        /// Verify that ServicSettings will accept unknown Windows Azure RDFE location.
        /// </summary>
        [TestMethod]
        public void GetDefaultLocationWithUnknwonLocation()
        {
            // Create a temp directory that we'll use to "publish" our service
            using (FileSystemHelper files = new FileSystemHelper(this) { EnableMonitoring = true })
            {
                // Import our default publish settings
                files.CreateAzureSdkDirectoryAndImportPublishSettings();
                string serviceName = null;
                string unknownLocation = "Unknown Location";

                ServiceSettings settings = ServiceSettings.LoadDefault(null, null, unknownLocation, null, null, null, "My-Custom-Service!", null, out serviceName);
                Assert.AreEqual<string>(unknownLocation.ToLower(), settings.Location.ToLower());

            }
        }
    }
}