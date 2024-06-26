// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    internal class WebSiteSlotSourceControlOperationSource : IOperationSource<WebSiteSlotSourceControlResource>
    {
        private readonly ArmClient _client;

        internal WebSiteSlotSourceControlOperationSource(ArmClient client)
        {
            _client = client;
        }

        WebSiteSlotSourceControlResource IOperationSource<WebSiteSlotSourceControlResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteSourceControlData.DeserializeSiteSourceControlData(document.RootElement);
            return new WebSiteSlotSourceControlResource(_client, data);
        }

        async ValueTask<WebSiteSlotSourceControlResource> IOperationSource<WebSiteSlotSourceControlResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteSourceControlData.DeserializeSiteSourceControlData(document.RootElement);
            return new WebSiteSlotSourceControlResource(_client, data);
        }
    }
}
