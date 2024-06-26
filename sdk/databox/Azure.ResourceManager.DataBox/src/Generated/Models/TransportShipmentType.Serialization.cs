// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    internal static partial class TransportShipmentTypeExtensions
    {
        public static string ToSerialString(this TransportShipmentType value) => value switch
        {
            TransportShipmentType.CustomerManaged => "CustomerManaged",
            TransportShipmentType.MicrosoftManaged => "MicrosoftManaged",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TransportShipmentType value.")
        };

        public static TransportShipmentType ToTransportShipmentType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CustomerManaged")) return TransportShipmentType.CustomerManaged;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MicrosoftManaged")) return TransportShipmentType.MicrosoftManaged;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TransportShipmentType value.");
        }
    }
}
