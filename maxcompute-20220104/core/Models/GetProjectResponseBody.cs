// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProjectResponseBodyData Data { get; set; }
        public class GetProjectResponseBodyData : TeaModel {
            /// <summary>
            /// The comment of the project.
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The storage usage.
            /// </summary>
            [NameInMap("costStorage")]
            [Validation(Required=false)]
            public string CostStorage { get; set; }

            /// <summary>
            /// Create time
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The default computing quota.
            /// </summary>
            [NameInMap("defaultQuota")]
            [Validation(Required=false)]
            public string DefaultQuota { get; set; }

            /// <summary>
            /// The IP address whitelist.
            /// </summary>
            [NameInMap("ipWhiteList")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataIpWhiteList IpWhiteList { get; set; }
            public class GetProjectResponseBodyDataIpWhiteList : TeaModel {
                /// <summary>
                /// The list of IP addresses.
                /// </summary>
                [NameInMap("ipList")]
                [Validation(Required=false)]
                public string IpList { get; set; }

                /// <summary>
                /// The list of virtual private cloud (VPC) IP addresses.
                /// </summary>
                [NameInMap("vpcIpList")]
                [Validation(Required=false)]
                public string VpcIpList { get; set; }

            }

            /// <summary>
            /// The name of the MaxCompute project.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The owner of the project.
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The billing method of the project.
            /// </summary>
            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// The properties of the project.
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataProperties Properties { get; set; }
            public class GetProjectResponseBodyDataProperties : TeaModel {
                /// <summary>
                /// Indicates whether a full table scan on the project is enabled.
                /// </summary>
                [NameInMap("allowFullScan")]
                [Validation(Required=false)]
                public bool? AllowFullScan { get; set; }

                /// <summary>
                /// This operation does not return a value for this parameter.
                /// </summary>
                [NameInMap("elderTunnelQuota")]
                [Validation(Required=false)]
                public string ElderTunnelQuota { get; set; }

                /// <summary>
                /// Indicates whether the DECIMAL data type in MaxCompute V2.0 is enabled.
                /// </summary>
                [NameInMap("enableDecimal2")]
                [Validation(Required=false)]
                public bool? EnableDecimal2 { get; set; }

                /// <summary>
                /// Indicates whether tunnel quota routing is enabled.
                /// </summary>
                [NameInMap("enableTunnelQuotaRoute")]
                [Validation(Required=false)]
                public bool? EnableTunnelQuotaRoute { get; set; }

                /// <summary>
                /// The encryption information.
                /// </summary>
                [NameInMap("encryption")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesEncryption Encryption { get; set; }
                public class GetProjectResponseBodyDataPropertiesEncryption : TeaModel {
                    /// <summary>
                    /// The name of the encryption algorithm.
                    /// </summary>
                    [NameInMap("algorithm")]
                    [Validation(Required=false)]
                    public string Algorithm { get; set; }

                    /// <summary>
                    /// Indicates whether data encryption is enabled. Valid values: true and false.
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// The key of the encryption algorithm.
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// The number of days for which backup data can be retained.
                /// </summary>
                [NameInMap("retentionDays")]
                [Validation(Required=false)]
                public long? RetentionDays { get; set; }

                /// <summary>
                /// The upper limit for the resources that are consumed by an SQL statement.
                /// </summary>
                [NameInMap("sqlMeteringMax")]
                [Validation(Required=false)]
                public string SqlMeteringMax { get; set; }

                /// <summary>
                /// The information about the tiered storage.
                /// </summary>
                [NameInMap("storageTierInfo")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesStorageTierInfo StorageTierInfo { get; set; }
                public class GetProjectResponseBodyDataPropertiesStorageTierInfo : TeaModel {
                    /// <summary>
                    /// The backup storage.
                    /// </summary>
                    [NameInMap("projectBackupSize")]
                    [Validation(Required=false)]
                    public long? ProjectBackupSize { get; set; }

                    /// <summary>
                    /// The total storage.
                    /// </summary>
                    [NameInMap("projectTotalSize")]
                    [Validation(Required=false)]
                    public long? ProjectTotalSize { get; set; }

                    /// <summary>
                    /// The tiered storage.
                    /// </summary>
                    [NameInMap("storageTierSize")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesStorageTierInfoStorageTierSize StorageTierSize { get; set; }
                    public class GetProjectResponseBodyDataPropertiesStorageTierInfoStorageTierSize : TeaModel {
                        /// <summary>
                        /// The long-term storage.
                        /// </summary>
                        [NameInMap("longTermSize")]
                        [Validation(Required=false)]
                        public long? LongTermSize { get; set; }

                        /// <summary>
                        /// The IA storage.
                        /// </summary>
                        [NameInMap("lowFrequencySize")]
                        [Validation(Required=false)]
                        public long? LowFrequencySize { get; set; }

                        /// <summary>
                        /// The standard storage.
                        /// </summary>
                        [NameInMap("standardSize")]
                        [Validation(Required=false)]
                        public long? StandardSize { get; set; }

                    }

                }

                /// <summary>
                /// The lifecycle of the table in the project.
                /// </summary>
                [NameInMap("tableLifecycle")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesTableLifecycle TableLifecycle { get; set; }
                public class GetProjectResponseBodyDataPropertiesTableLifecycle : TeaModel {
                    /// <summary>
                    /// The type of the lifecycle. Valid values: -**mandatory**: The lifecycle clause is required. You must configure a lifecycle for a table. -**optional**: The lifecycle clause is optional in a table creation statement. If you do not configure a lifecycle for a table, the table does not expire. -**inherit**: If you do not configure a lifecycle for a table when you create the table, the value of the odps.table.lifecycle.value parameter is used by default.
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The retention period of a table. Unit: days.
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The time zone of the project.
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// The name of the tunnel quota.
                /// </summary>
                [NameInMap("tunnelQuota")]
                [Validation(Required=false)]
                public string TunnelQuota { get; set; }

                /// <summary>
                /// The data type edition. Valid values: -**1**: MaxCompute V1.0 data type edition. -**2**: MaxCompute V2.0 data type edition. -**hive**: Hive-compatible data type edition.
                /// </summary>
                [NameInMap("typeSystem")]
                [Validation(Required=false)]
                public string TypeSystem { get; set; }

            }

            /// <summary>
            /// RegionID
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The tag.
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataSaleTag SaleTag { get; set; }
            public class GetProjectResponseBodyDataSaleTag : TeaModel {
                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// The permission properties.
            /// </summary>
            [NameInMap("securityProperties")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataSecurityProperties SecurityProperties { get; set; }
            public class GetProjectResponseBodyDataSecurityProperties : TeaModel {
                /// <summary>
                /// Indicates whether Download control is enabled.
                /// </summary>
                [NameInMap("enableDownloadPrivilege")]
                [Validation(Required=false)]
                public bool? EnableDownloadPrivilege { get; set; }

                /// <summary>
                /// Indicates whether label-based access control is enabled.
                /// </summary>
                [NameInMap("labelSecurity")]
                [Validation(Required=false)]
                public bool? LabelSecurity { get; set; }

                /// <summary>
                /// Indicates whether the object creator is allowed to perform operations on objects.
                /// </summary>
                [NameInMap("objectCreatorHasAccessPermission")]
                [Validation(Required=false)]
                public bool? ObjectCreatorHasAccessPermission { get; set; }

                /// <summary>
                /// Indicates whether the object creator is allowed to authorize other users to perform operations on objects.
                /// </summary>
                [NameInMap("objectCreatorHasGrantPermission")]
                [Validation(Required=false)]
                public bool? ObjectCreatorHasGrantPermission { get; set; }

                /// <summary>
                /// Indicates whether project data protection is enabled.
                /// </summary>
                [NameInMap("projectProtection")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                public class GetProjectResponseBodyDataSecurityPropertiesProjectProtection : TeaModel {
                    /// <summary>
                    /// The exception policy. If cross-project data access operations are required, the project owner must configure an exception policy in advance to allow the specified user to transfer data of a specified object from the current project to a specified project. After the exception policy is configured, data of the object can be transferred to the specified project even if the project data protection feature is enabled.
                    /// </summary>
                    [NameInMap("exceptionPolicy")]
                    [Validation(Required=false)]
                    public string ExceptionPolicy { get; set; }

                    /// <summary>
                    /// Indicates whether project data protection is enabled.
                    /// </summary>
                    [NameInMap("protected")]
                    [Validation(Required=false)]
                    public bool? Protected { get; set; }

                }

                /// <summary>
                /// Indicates whether ACL-based access control is enabled.
                /// </summary>
                [NameInMap("usingAcl")]
                [Validation(Required=false)]
                public bool? UsingAcl { get; set; }

                /// <summary>
                /// Indicates whether policy-based access control is enabled.
                /// </summary>
                [NameInMap("usingPolicy")]
                [Validation(Required=false)]
                public bool? UsingPolicy { get; set; }

            }

            /// <summary>
            /// The status of the project. Valid values: -**AVAILABLE**: The project was available. -**READONLY**: The project was read only. -**FROZEN**: The project was frozen. -**DELETING**: The project was being deleted.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The Super_Administrator role.
            /// </summary>
            [NameInMap("superAdmins")]
            [Validation(Required=false)]
            public List<string> SuperAdmins { get; set; }

            /// <summary>
            /// Indicates whether the current project supports the three-layer model of MaxCompute.
            /// </summary>
            [NameInMap("threeTierModel")]
            [Validation(Required=false)]
            public bool? ThreeTierModel { get; set; }

            /// <summary>
            /// The type of the project. Valid values: -**managed**: The project is an internal project. -**external**: The project is an external project.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
