// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.DevCenter.DevBox.Tests
{
    public class DevBoxClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("DevBox_ENDPOINT");

        // Add other client paramters here as above.
    }
}
