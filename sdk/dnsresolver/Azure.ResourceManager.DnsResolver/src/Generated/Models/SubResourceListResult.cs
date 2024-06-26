// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> The response to an enumeration operation on sub-resources. </summary>
    internal partial class SubResourceListResult
    {
        /// <summary> Initializes a new instance of <see cref="SubResourceListResult"/>. </summary>
        internal SubResourceListResult()
        {
            Value = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="SubResourceListResult"/>. </summary>
        /// <param name="value"> Enumeration of the sub-resources. </param>
        /// <param name="nextLink"> The continuation token for the next page of results. </param>
        internal SubResourceListResult(IReadOnlyList<WritableSubResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Enumeration of the sub-resources. </summary>
        public IReadOnlyList<WritableSubResource> Value { get; }
        /// <summary> The continuation token for the next page of results. </summary>
        public string NextLink { get; }
    }
}
