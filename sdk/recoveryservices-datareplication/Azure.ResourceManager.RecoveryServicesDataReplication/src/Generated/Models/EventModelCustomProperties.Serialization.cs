// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class EventModelCustomProperties
    {
        internal static EventModelCustomProperties DeserializeEventModelCustomProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "HyperVToAzStackHCI": return HyperVToAzStackHciEventModelCustomProperties.DeserializeHyperVToAzStackHciEventModelCustomProperties(element);
                }
            }
            return UnknownEventModelCustomProperties.DeserializeUnknownEventModelCustomProperties(element);
        }
    }
}
