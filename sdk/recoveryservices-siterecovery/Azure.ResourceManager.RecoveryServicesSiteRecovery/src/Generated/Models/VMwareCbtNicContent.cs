// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt NIC input. </summary>
    public partial class VMwareCbtNicContent
    {
        /// <summary> Initializes a new instance of <see cref="VMwareCbtNicContent"/>. </summary>
        /// <param name="nicId"> The NIC Id. </param>
        /// <param name="isPrimaryNic"> A value indicating whether this is the primary NIC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nicId"/> or <paramref name="isPrimaryNic"/> is null. </exception>
        public VMwareCbtNicContent(string nicId, string isPrimaryNic)
        {
            Argument.AssertNotNull(nicId, nameof(nicId));
            Argument.AssertNotNull(isPrimaryNic, nameof(isPrimaryNic));

            NicId = nicId;
            IsPrimaryNic = isPrimaryNic;
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtNicContent"/>. </summary>
        /// <param name="nicId"> The NIC Id. </param>
        /// <param name="isPrimaryNic"> A value indicating whether this is the primary NIC. </param>
        /// <param name="targetSubnetName"> Target subnet name. </param>
        /// <param name="targetStaticIPAddress"> The static IP address. </param>
        /// <param name="isSelectedForMigration"> A value indicating whether this NIC is selected for migration. </param>
        /// <param name="targetNicName"> Target NIC name. </param>
        /// <param name="testSubnetName"> The test subnet name. </param>
        /// <param name="testStaticIPAddress"> The test static IP address. </param>
        internal VMwareCbtNicContent(string nicId, string isPrimaryNic, string targetSubnetName, IPAddress targetStaticIPAddress, string isSelectedForMigration, string targetNicName, string testSubnetName, IPAddress testStaticIPAddress)
        {
            NicId = nicId;
            IsPrimaryNic = isPrimaryNic;
            TargetSubnetName = targetSubnetName;
            TargetStaticIPAddress = targetStaticIPAddress;
            IsSelectedForMigration = isSelectedForMigration;
            TargetNicName = targetNicName;
            TestSubnetName = testSubnetName;
            TestStaticIPAddress = testStaticIPAddress;
        }

        /// <summary> The NIC Id. </summary>
        public string NicId { get; }
        /// <summary> A value indicating whether this is the primary NIC. </summary>
        public string IsPrimaryNic { get; }
        /// <summary> Target subnet name. </summary>
        public string TargetSubnetName { get; set; }
        /// <summary> The static IP address. </summary>
        public IPAddress TargetStaticIPAddress { get; set; }
        /// <summary> A value indicating whether this NIC is selected for migration. </summary>
        public string IsSelectedForMigration { get; set; }
        /// <summary> Target NIC name. </summary>
        public string TargetNicName { get; set; }
        /// <summary> The test subnet name. </summary>
        public string TestSubnetName { get; set; }
        /// <summary> The test static IP address. </summary>
        public IPAddress TestStaticIPAddress { get; set; }
    }
}
