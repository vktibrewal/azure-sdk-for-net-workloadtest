// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class AddParticipantResponseInternal
    {
        internal static AddParticipantResponseInternal DeserializeAddParticipantResponseInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CallParticipantInternal> participant = default;
            Optional<string> operationContext = default;
            Optional<string> invitationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("participant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    participant = CallParticipantInternal.DeserializeCallParticipantInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invitationId"u8))
                {
                    invitationId = property.Value.GetString();
                    continue;
                }
            }
            return new AddParticipantResponseInternal(participant.Value, operationContext.Value, invitationId.Value);
        }
    }
}
