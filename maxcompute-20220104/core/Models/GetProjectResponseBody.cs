// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProjectResponseBodyData Data { get; set; }
        public class GetProjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The project description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>maxcompute project</para>
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The total storage usage. The storage space that is occupied by your project, which is the logical storage space after your project data is collected and compressed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16489027</para>
            /// </summary>
            [NameInMap("costStorage")]
            [Validation(Required=false)]
            public string CostStorage { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1704380838000</para>
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The default computing quota that is used to allocate computing resources. If you do not specify a computing quota for your project, the jobs that are initiated by your project consume the computing resources in the default quota. For more information about how to use computing resources, see <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/use-of-computing-resources">Use quota groups for computing resources</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota_a</para>
            /// </summary>
            [NameInMap("defaultQuota")]
            [Validation(Required=false)]
            public string DefaultQuota { get; set; }

            /// <summary>
            /// <para>The information about the IP address whitelist.</para>
            /// </summary>
            [NameInMap("ipWhiteList")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataIpWhiteList IpWhiteList { get; set; }
            public class GetProjectResponseBodyDataIpWhiteList : TeaModel {
                /// <summary>
                /// <para>The IP address whitelist for access over the Internet or the network for interconnecting with other Alibaba Cloud services.</para>
                /// <remarks>
                /// <para> If you configure only the IP address whitelist for access over the Internet or the network for interconnecting with other Alibaba Cloud services, the access over the Internet or the network for interconnecting with other Alibaba Cloud services is subject to configurations, and access over a virtual private cloud (VPC) is not allowed.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10.88.111.3</para>
                /// </summary>
                [NameInMap("ipList")]
                [Validation(Required=false)]
                public string IpList { get; set; }

                /// <summary>
                /// <para>The IP address whitelist for access over a VPC.</para>
                /// <remarks>
                /// <para> If you configure only the IP address whitelist for access over a VPC, the access over a VPC is subject to configurations, and the access over the Internet or the network for interconnecting with other Alibaba Cloud services is not allowed.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10.88.111.3</para>
                /// </summary>
                [NameInMap("vpcIpList")]
                [Validation(Required=false)]
                public string VpcIpList { get; set; }

            }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps_project</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The account information of the project owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565950907343451</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The billing method of the default computing quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayAsYouGo</para>
            /// </summary>
            [NameInMap("productType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The basic properties of the project.</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataProperties Properties { get; set; }
            public class GetProjectResponseBodyDataProperties : TeaModel {
                /// <summary>
                /// <para>Indicates whether a full table scan is allowed in the project. A full table scan occupies a large number of resources, which reduces data processing efficiency. By default, the full table scan feature is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("allowFullScan")]
                [Validation(Required=false)]
                public bool? AllowFullScan { get; set; }

                [NameInMap("autoMvQuotaGb")]
                [Validation(Required=false)]
                public long? AutoMvQuotaGb { get; set; }

                /// <summary>
                /// <para>The Tunnel parent resource group that is bound to the project. You do not need to pay attention to this group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No value</para>
                /// </summary>
                [NameInMap("elderTunnelQuota")]
                [Validation(Required=false)]
                public string ElderTunnelQuota { get; set; }

                [NameInMap("enableAutoMv")]
                [Validation(Required=false)]
                public bool? EnableAutoMv { get; set; }

                /// <summary>
                /// <para>Indicates whether the DECIMAL type of the MaxCompute V2.0 data type edition is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableDecimal2")]
                [Validation(Required=false)]
                public bool? EnableDecimal2 { get; set; }

                [NameInMap("enableDr")]
                [Validation(Required=false)]
                public bool? EnableDr { get; set; }

                /// <summary>
                /// <para>Indicates whether external table caching is forcefully enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableFdcCacheForce")]
                [Validation(Required=false)]
                public bool? EnableFdcCacheForce { get; set; }

                /// <summary>
                /// <para>Indicates whether <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tiered-storage">tiered storage</a> is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableTieredStorage")]
                [Validation(Required=false)]
                public bool? EnableTieredStorage { get; set; }

                /// <summary>
                /// <para>Indicates whether the routing of the Tunnel resource group is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true: The data transfer tasks that are submitted by the project by default use the Tunnel resource group that is bound to the project.</description></item>
                /// <item><description>false: The data transfer tasks that are submitted by the project by default use the Tunnel shared resource group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableTunnelQuotaRoute")]
                [Validation(Required=false)]
                public bool? EnableTunnelQuotaRoute { get; set; }

                /// <summary>
                /// <para>The storage encryption properties.</para>
                /// </summary>
                [NameInMap("encryption")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesEncryption Encryption { get; set; }
                public class GetProjectResponseBodyDataPropertiesEncryption : TeaModel {
                    /// <summary>
                    /// <para>The data encryption algorithm that is supported by the key. Valid values: AES256, AESCTR, and RC4.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SHA1</para>
                    /// </summary>
                    [NameInMap("algorithm")]
                    [Validation(Required=false)]
                    public string Algorithm { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the data encryption feature needs to be enabled for the project. For more information about data encryption, see</para>
                    /// <para><a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/storage-encryption">Storage encryption</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The type of key that is used for data encryption. You can select MaxCompute Default Key or Bring Your Own Key (BYOK) as the key type. If you select MaxCompute Default Key, the default key that is created by MaxCompute is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dafault</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// <para>The properties of the external project.</para>
                /// </summary>
                [NameInMap("externalProjectProperties")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesExternalProjectProperties ExternalProjectProperties { get; set; }
                public class GetProjectResponseBodyDataPropertiesExternalProjectProperties : TeaModel {
                    [NameInMap("externalCatalogId")]
                    [Validation(Required=false)]
                    public string ExternalCatalogId { get; set; }

                    [NameInMap("foreignServerName")]
                    [Validation(Required=false)]
                    public string ForeignServerName { get; set; }

                    [NameInMap("foreignServerType")]
                    [Validation(Required=false)]
                    public string ForeignServerType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the external project is an external project for <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/lake-warehouse-integrated-2-0-use-guide">data lakehouse solution 2.0</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("isExternalCatalogBound")]
                    [Validation(Required=false)]
                    public string IsExternalCatalogBound { get; set; }

                    [NameInMap("tableFormat")]
                    [Validation(Required=false)]
                    public string TableFormat { get; set; }

                    [NameInMap("warehouse")]
                    [Validation(Required=false)]
                    public string Warehouse { get; set; }

                }

                /// <summary>
                /// <para>The quota for external table caching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fdc_quota</para>
                /// </summary>
                [NameInMap("fdcQuota")]
                [Validation(Required=false)]
                public string FdcQuota { get; set; }

                /// <summary>
                /// <para>The retention period for backup data. Unit: days. During the retention period, you can restore data of the version in use to the backup data of any version. Valid values: [0,30]. Default value: 1. The value 0 indicates that the backup feature is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("retentionDays")]
                [Validation(Required=false)]
                public long? RetentionDays { get; set; }

                /// <summary>
                /// <para>The maximum consumption threshold of a single SQL statement. Formula: Amount of scanned data (GB) × Complexity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1500</para>
                /// </summary>
                [NameInMap("sqlMeteringMax")]
                [Validation(Required=false)]
                public string SqlMeteringMax { get; set; }

                /// <summary>
                /// <para>The <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tiered-storage">storage tier</a> information.</para>
                /// </summary>
                [NameInMap("storageTierInfo")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesStorageTierInfo StorageTierInfo { get; set; }
                public class GetProjectResponseBodyDataPropertiesStorageTierInfo : TeaModel {
                    /// <summary>
                    /// <para>The backup storage usage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86672917</para>
                    /// </summary>
                    [NameInMap("projectBackupSize")]
                    [Validation(Required=false)]
                    public long? ProjectBackupSize { get; set; }

                    /// <summary>
                    /// <para>The total storage usage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>56066037</para>
                    /// </summary>
                    [NameInMap("projectTotalSize")]
                    [Validation(Required=false)]
                    public long? ProjectTotalSize { get; set; }

                    /// <summary>
                    /// <para>The <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tiered-storage">storage tier</a> information.</para>
                    /// </summary>
                    [NameInMap("storageTierSize")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesStorageTierInfoStorageTierSize StorageTierSize { get; set; }
                    public class GetProjectResponseBodyDataPropertiesStorageTierInfoStorageTierSize : TeaModel {
                        /// <summary>
                        /// <para>The storage usage at the long-term storage tier.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21764917</para>
                        /// </summary>
                        [NameInMap("longTermSize")]
                        [Validation(Required=false)]
                        public long? LongTermSize { get; set; }

                        /// <summary>
                        /// <para>The storage usage at the Infrequent Access (IA) layer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>767693</para>
                        /// </summary>
                        [NameInMap("lowFrequencySize")]
                        [Validation(Required=false)]
                        public long? LowFrequencySize { get; set; }

                        /// <summary>
                        /// <para>The storage usage at the standard storage tier.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>27649172</para>
                        /// </summary>
                        [NameInMap("standardSize")]
                        [Validation(Required=false)]
                        public long? StandardSize { get; set; }

                    }

                }

                /// <summary>
                /// <para>The table lifecycle properties.</para>
                /// </summary>
                [NameInMap("tableLifecycle")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesTableLifecycle TableLifecycle { get; set; }
                public class GetProjectResponseBodyDataPropertiesTableLifecycle : TeaModel {
                    /// <summary>
                    /// <para>The lifecycle type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>mandatory</b>: The lifecycle clause is required in a table creation statement.</description></item>
                    /// <item><description><b>optional</b>: The lifecycle clause is optional in a table creation statement. If you do not configure a lifecycle for a table, the table does not expire.</description></item>
                    /// <item><description><b>inherit</b>: If you do not configure a lifecycle for a table when you create the table, the value of the odps.table.lifecycle.value parameter is used as the table lifecycle by default.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>optional</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The table lifecycle. Unit: days. Valid values: 1 to 37231. Default value: 37231.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>37231</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tiered-storage#f61fc9db76nna">properties of tiered storage lifecycle rules</a>. After you configure the properties, the system triggers automatic switching of storage tiers based on the rules.</para>
                /// </summary>
                [NameInMap("tableLifecycleConfig")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesTableLifecycleConfig TableLifecycleConfig { get; set; }
                public class GetProjectResponseBodyDataPropertiesTableLifecycleConfig : TeaModel {
                    /// <summary>
                    /// <para>The information about the long-term storage tier.</para>
                    /// </summary>
                    [NameInMap("TierToLongterm")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLongterm TierToLongterm { get; set; }
                    public class GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLongterm : TeaModel {
                        /// <summary>
                        /// <para>The system triggers an automatic storage tier change N days after the last access time of data. N is specified by this parameter and corresponds to <c>LastAccessTime</c> that is configured for the table or partition.</para>
                        /// <remarks>
                        /// <para> If LastAccessTime of a table or partition is left empty, the following rules are applied:</para>
                        /// </remarks>
                        /// <list type="bullet">
                        /// <item><description><para>For tables or partitions that you created before October 1, 2023, 2023.10.01 00:00:00 in UTC+0 is considered as the last access time.</para>
                        /// </description></item>
                        /// <item><description><para>For tables or partitions that you created on or after October 1, 2023, if no data is accessed, the table or partition creation time is considered as the last access time.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>180</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastAccessGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastAccessGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The system triggers an automatic storage tier change N days after the last modification time of data. N is specified by this parameter and corresponds to <c>LastModifiedTime</c> that is configured for the table or partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>180</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastModificationGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The period after the previous storage tier change time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastTierModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastTierModificationGreaterThan { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the IA storage tier.</para>
                    /// </summary>
                    [NameInMap("TierToLowFrequency")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLowFrequency TierToLowFrequency { get; set; }
                    public class GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLowFrequency : TeaModel {
                        /// <summary>
                        /// <para>The system triggers an automatic storage tier change N days after the last access time of data. N is specified by this parameter and corresponds to <c>LastAccessTime</c> that is configured for the table or partition.</para>
                        /// <remarks>
                        /// <para> If LastAccessTime of a table or partition is left empty, the following rules are applied:</para>
                        /// </remarks>
                        /// <list type="bullet">
                        /// <item><description><para>For tables or partitions that you created before October 1, 2023, 2023.10.01 00:00:00 in UTC+0 is considered as the last access time.</para>
                        /// </description></item>
                        /// <item><description><para>For tables or partitions that you created on or after October 1, 2023, if no data is accessed, the table or partition creation time is considered as the last access time.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastAccessGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastAccessGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The system triggers an automatic storage tier change N days after the last modification time of data. N is specified by this parameter and corresponds to <c>LastModifiedTime</c> that is configured for the table or partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastModificationGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The period after the previous storage tier change time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastTierModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastTierModificationGreaterThan { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time zone that is used by your project. The time zone is the same as the time zone specified by <c>odps.sql.timezone</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <para>The <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/overview-of-dts">Tunnel</a> resource group that is bound to the project.</para>
                /// <list type="bullet">
                /// <item><description>Default resource group: The Tunnel shared resource group is used. You cannot use the subscription-based Tunnel resource group for the project. The default resource group is automatically used by the Tunnel service of your project, regardless of the parameter setting.</description></item>
                /// <item><description>Subscription-based Tunnel resource group: You can use the subscription-based Tunnel resource group for the project.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Quota</para>
                /// </summary>
                [NameInMap("tunnelQuota")]
                [Validation(Required=false)]
                public string TunnelQuota { get; set; }

                /// <summary>
                /// <para>The data type edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: MaxCompute V1.0 data type edition</description></item>
                /// <item><description><b>2</b>: MaxCompute V2.0 data type edition</description></item>
                /// <item><description><b>hive</b>: Hive-compatible data type edition</description></item>
                /// </list>
                /// <para>For more information about the differences among the three data type editions, see <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/data-type-editions">Data type editions</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("typeSystem")]
                [Validation(Required=false)]
                public string TypeSystem { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The instance ID and billing method of the default computing quota.</para>
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataSaleTag SaleTag { get; set; }
            public class GetProjectResponseBodyDataSaleTag : TeaModel {
                /// <summary>
                /// <para>The instance ID of the default computing quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project_name</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The billing method of the default computing quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The permission properties.</para>
            /// </summary>
            [NameInMap("securityProperties")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataSecurityProperties SecurityProperties { get; set; }
            public class GetProjectResponseBodyDataSecurityProperties : TeaModel {
                /// <summary>
                /// <para>Indicates whether the <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/label-based-access-control">download control</a> feature is enabled. By default, this feature is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enableDownloadPrivilege")]
                [Validation(Required=false)]
                public bool? EnableDownloadPrivilege { get; set; }

                /// <summary>
                /// <para>Indicates whether the <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/label-based-access-control">label-based access control</a> feature is enabled. By default, this feature is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("labelSecurity")]
                [Validation(Required=false)]
                public bool? LabelSecurity { get; set; }

                /// <summary>
                /// <para>Indicates whether to allow the object creator to have the access permissions on the object. The default value is true, which indicates that the object creator has the access permissions on the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("objectCreatorHasAccessPermission")]
                [Validation(Required=false)]
                public bool? ObjectCreatorHasAccessPermission { get; set; }

                /// <summary>
                /// <para>Indicates whether the object creator has the authorization permissions on the object. The default value is true, which indicates that the object creator has the authorization permissions on the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("objectCreatorHasGrantPermission")]
                [Validation(Required=false)]
                public bool? ObjectCreatorHasGrantPermission { get; set; }

                /// <summary>
                /// <para>The properties of the <a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a>.</para>
                /// </summary>
                [NameInMap("projectProtection")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                public class GetProjectResponseBodyDataSecurityPropertiesProjectProtection : TeaModel {
                    /// <summary>
                    /// <para>If you enable the project data protection mechanism, you can configure exception or trusted projects. This allows specified users to transfer data of a specified object to a specified project. The project data protection mechanism does not take effect in all the situations that are specified in the exception policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;Version&quot;: &quot;1&quot;,
                    ///     &quot;Statement&quot;:
                    ///     [{
                    ///         &quot;Effect&quot;:&quot;Allow&quot;,
                    ///         &quot;Principal&quot;:&quot;<Principal>&quot;,
                    ///         &quot;Action&quot;:[&quot;odps:<Action1>[, <Action2>, ...]&quot;],
                    ///         &quot;Resource&quot;:&quot;acs:odps:*:<Resource>&quot;,
                    ///         &quot;Condition&quot;:{
                    ///             &quot;StringEquals&quot;: {
                    ///                 &quot;odps:TaskType&quot;:[&quot;<Tasktype>&quot;]
                    ///             }
                    ///         }
                    ///     }]
                    ///     }</para>
                    /// </summary>
                    [NameInMap("exceptionPolicy")]
                    [Validation(Required=false)]
                    public string ExceptionPolicy { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the <a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a> is enabled for the project. This allows or denies data transfer across projects. By default, the data protection mechanism is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("protected")]
                    [Validation(Required=false)]
                    public bool? Protected { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/acl-based-access-control">ACL-based access control</a> feature is enabled. By default, this feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("usingAcl")]
                [Validation(Required=false)]
                public bool? UsingAcl { get; set; }

                /// <summary>
                /// <para>Indicates whether the <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/policy-based-access-control-1">policy-based access control</a> feature is enabled. By default, this feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("usingPolicy")]
                [Validation(Required=false)]
                public bool? UsingPolicy { get; set; }

            }

            /// <summary>
            /// <para>The project status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AVAILABLE</b></description></item>
            /// <item><description><b>READONLY</b></description></item>
            /// <item><description><b>FROZEN</b></description></item>
            /// <item><description><b>DELETING</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of <c>Super_Administrator</c> role members of the project.</para>
            /// </summary>
            [NameInMap("superAdmins")]
            [Validation(Required=false)]
            public List<string> SuperAdmins { get; set; }

            /// <summary>
            /// <para>Indicates whether data storage by schema is supported. MaxCompute supports the schema feature. This feature allows you to classify objects such as tables, resources, and user-defined functions (UDFs) in a project by schema. You can create multiple schemas in a project. For more information, see <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/schema-related-operations">Schema-related operations</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("threeTierModel")]
            [Validation(Required=false)]
            public bool? ThreeTierModel { get; set; }

            /// <summary>
            /// <para>The project type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>managed</b>: internal project</description></item>
            /// <item><description><b>external</b>: external project</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>managed</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>040002</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>error message.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: informational response. The request is received and is being processed.</description></item>
        /// <item><description>2xx: success. The request is successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: redirection. The request is redirected, and further actions are required to complete the request.</description></item>
        /// <item><description>4xx: client error. The request contains invalid request parameters and syntaxes, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: server error. The server cannot meet requirements due to other reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b87b7b316643495896551555e855b</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
