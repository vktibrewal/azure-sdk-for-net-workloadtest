// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesBucketUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            if (Optional.IsDefined(BucketName))
            {
                if (BucketName != null)
                {
                    writer.WritePropertyName("bucketName"u8);
                    writer.WriteStringValue(BucketName);
                }
                else
                {
                    writer.WriteNull("bucketName");
                }
            }
            if (Optional.IsDefined(UseInsecureCommunication))
            {
                if (UseInsecureCommunication != null)
                {
                    writer.WritePropertyName("insecure"u8);
                    writer.WriteBooleanValue(UseInsecureCommunication.Value);
                }
                else
                {
                    writer.WriteNull("insecure");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(AccessKey))
            {
                if (AccessKey != null)
                {
                    writer.WritePropertyName("accessKey"u8);
                    writer.WriteStringValue(AccessKey);
                }
                else
                {
                    writer.WriteNull("accessKey");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef"u8);
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
                }
            }
            writer.WriteEndObject();
        }
    }
}
