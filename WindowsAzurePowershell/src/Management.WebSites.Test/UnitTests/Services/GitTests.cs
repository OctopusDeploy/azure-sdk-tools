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

namespace Microsoft.WindowsAzure.Management.Websites.Test.UnitTests.Services
{
    using VisualStudio.TestTools.UnitTesting;
    using Websites.Services;

    [TestClass]
    public class GitTests
    {
        [TestMethod]
        public void TestSetGetConfigurationValue()
        {
            // Set configuration
            Git.SetConfigurationValue("azure.test", "value");

            string value = Git.GetConfigurationValue("azure.test");
            Assert.AreEqual("value", value);

            // Clear configuration
            Git.ClearConfigurationValue("azure.test");

            value = Git.GetConfigurationValue("azure.test");
            Assert.IsTrue(string.IsNullOrEmpty(value));
        }
    }
}