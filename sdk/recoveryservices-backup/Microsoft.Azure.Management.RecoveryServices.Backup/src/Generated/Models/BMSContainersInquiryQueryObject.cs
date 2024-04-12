// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The query filters that can be used with the inquire container API.
    /// </summary>
    public partial class BMSContainersInquiryQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the BMSContainersInquiryQueryObject
        /// class.
        /// </summary>
        public BMSContainersInquiryQueryObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BMSContainersInquiryQueryObject
        /// class.
        /// </summary>
        /// <param name="backupManagementType">Backup management type for this
        /// container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage',
        /// 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="workloadType">Workload type for this container.
        /// Possible values include: 'Invalid', 'VM', 'FileFolder',
        /// 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint', 'VMwareVM',
        /// 'SystemState', 'Client', 'GenericDataSource', 'SQLDataBase',
        /// 'AzureFileShare', 'SAPHanaDatabase', 'SAPAseDatabase',
        /// 'SAPHanaDBInstance', 'SQLInstance'</param>
        public BMSContainersInquiryQueryObject(string backupManagementType = default(string), string workloadType = default(string))
        {
            BackupManagementType = backupManagementType;
            WorkloadType = workloadType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup management type for this container. Possible
        /// values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql', 'AzureStorage', 'AzureWorkload',
        /// 'DefaultBackup'
        /// </summary>
        [JsonProperty(PropertyName = "backupManagementType")]
        public string BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets workload type for this container. Possible values
        /// include: 'Invalid', 'VM', 'FileFolder', 'AzureSqlDb', 'SQLDB',
        /// 'Exchange', 'Sharepoint', 'VMwareVM', 'SystemState', 'Client',
        /// 'GenericDataSource', 'SQLDataBase', 'AzureFileShare',
        /// 'SAPHanaDatabase', 'SAPAseDatabase', 'SAPHanaDBInstance',
        /// 'SQLInstance'
        /// </summary>
        [JsonProperty(PropertyName = "workloadType")]
        public string WorkloadType { get; set; }

    }
}
