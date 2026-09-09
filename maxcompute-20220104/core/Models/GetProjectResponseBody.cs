// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProjectResponseBodyData Data { get; set; }
        public class GetProjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The project description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BI_Analysis</para>
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The total storage size.
            /// Views the current storage size of the project. This storage size is consistent with the metering caliber, which is the logical storage size after compression at the Project level.</para>
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
            /// <para>The default computing quota.
            /// Used to allocate computing resources. If no computing quota is specified, jobs initiated by this project will consume resources from the default quota. For more information about computing resource usage, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/use-of-computing-resources">Computing Resources - Quota Usage</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/use-of-computing-resources">Computing Resources - Quota Usage</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os_PayAsYouGoQuota</para>
            /// </summary>
            [NameInMap("defaultQuota")]
            [Validation(Required=false)]
            public string DefaultQuota { get; set; }

            /// <summary>
            /// <para>The IP whitelist.</para>
            /// </summary>
            [NameInMap("ipWhiteList")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataIpWhiteList IpWhiteList { get; set; }
            public class GetProjectResponseBodyDataIpWhiteList : TeaModel {
                /// <summary>
                /// <para>The IP whitelist for public network and cloud product interconnection network.</para>
                /// <remarks>
                /// <para>If only the public network and cloud product interconnection network IP whitelist is configured, access through the public network and cloud product interconnection network is restricted by the configuration, and all VPC network access is prohibited.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10.88.111.3</para>
                /// </summary>
                [NameInMap("ipList")]
                [Validation(Required=false)]
                public string IpList { get; set; }

                /// <summary>
                /// <para>The VPC network IP whitelist.</para>
                /// <remarks>
                /// <para>If only the VPC network IP whitelist is configured, VPC network access is restricted by the configuration, and all public network and cloud product interconnection network access is prohibited.</para>
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
            /// <para>ALIYUN$odps****@aliyunid.com</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The billing mode of the default computing quota.</para>
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
                /// <para>Whether full table scans are allowed in the project. Full table scans consume significant resources, so this feature is disabled by default to improve processing efficiency.</para>
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
                /// <para>The parent group of the Data Transfer Service resource group bound to the project (can be ignored).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default_p</para>
                /// </summary>
                [NameInMap("elderTunnelQuota")]
                [Validation(Required=false)]
                public string ElderTunnelQuota { get; set; }

                [NameInMap("enableAutoMv")]
                [Validation(Required=false)]
                public bool? EnableAutoMv { get; set; }

                [NameInMap("enableDataMasking")]
                [Validation(Required=false)]
                public bool? EnableDataMasking { get; set; }

                /// <summary>
                /// <para>Whether the MaxCompute 2.0 Decimal data type is enabled for the project.</para>
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
                /// <para>Whether to force enable external table caching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableFdcCacheForce")]
                [Validation(Required=false)]
                public bool? EnableFdcCacheForce { get; set; }

                /// <summary>
                /// <para>Whether &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/tiered-storage">tiered storage</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tiered-storage">tiered storage</a> is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableTieredStorage")]
                [Validation(Required=false)]
                public bool? EnableTieredStorage { get; set; }

                /// <summary>
                /// <para>Whether the Data Transfer Service resource group routing is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true: Data Transfer Service tasks submitted by this project will use the bound Data Transfer Service resource group by default.</description></item>
                /// <item><description>false: Data Transfer Service tasks submitted by this project will use the Data Transfer Service shared resource group by default.</description></item>
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
                    /// <para>The data encryption algorithm. Supported encryption algorithms include AES256, AESCTR, and RC4.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AES256</para>
                    /// </summary>
                    [NameInMap("algorithm")]
                    [Validation(Required=false)]
                    public string Algorithm { get; set; }

                    /// <summary>
                    /// <para>Whether data encryption is enabled for the project. For more information about data encryption, see
                    /// &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/security-and-compliance/storage-encryption">Storage Encryption</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/storage-encryption">Storage Encryption</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The key type used for data encryption, including the default key (MaxCompute Default Key) and Bring Your Own Key (BYOK). The default key (MaxCompute Default Key) is created internally by MaxCompute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dafault</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// <para>The external project properties.</para>
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
                    /// <para>Whether this is a &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/lake-warehouse-integrated-2-0-use-guide">Lakehouse 2.0</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/lake-warehouse-integrated-2-0-use-guide">Lakehouse 2.0</a> external project.</para>
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
                /// <para>The external table cache quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fdc_quota</para>
                /// </summary>
                [NameInMap("fdcQuota")]
                [Validation(Required=false)]
                public string FdcQuota { get; set; }

                /// <summary>
                /// <para>The number of days to retain backup data. During this period, you can restore the current version to any backed-up data version.
                /// Valid values: [0, 30]. Default value: 1. A value of 0 indicates that the backup feature is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("retentionDays")]
                [Validation(Required=false)]
                public long? RetentionDays { get; set; }

                /// <summary>
                /// <para>The maximum threshold for single SQL consumption.
                /// Unit: scan volume (GB) × complexity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1500</para>
                /// </summary>
                [NameInMap("sqlMeteringMax")]
                [Validation(Required=false)]
                public string SqlMeteringMax { get; set; }

                /// <summary>
                /// <para>The &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/tiered-storage">tiered storage</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tiered-storage">tiered storage</a> information.</para>
                /// </summary>
                [NameInMap("storageTierInfo")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesStorageTierInfo StorageTierInfo { get; set; }
                public class GetProjectResponseBodyDataPropertiesStorageTierInfo : TeaModel {
                    /// <summary>
                    /// <para>The backup storage size.</para>
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
                    /// <para>The &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/tiered-storage">tiered storage</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tiered-storage">tiered storage</a> information.</para>
                    /// </summary>
                    [NameInMap("storageTierSize")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesStorageTierInfoStorageTierSize StorageTierSize { get; set; }
                    public class GetProjectResponseBodyDataPropertiesStorageTierInfoStorageTierSize : TeaModel {
                        /// <summary>
                        /// <para>The long-term storage usage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21764917</para>
                        /// </summary>
                        [NameInMap("longTermSize")]
                        [Validation(Required=false)]
                        public long? LongTermSize { get; set; }

                        /// <summary>
                        /// <para>The infrequent access storage usage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>767693</para>
                        /// </summary>
                        [NameInMap("lowFrequencySize")]
                        [Validation(Required=false)]
                        public long? LowFrequencySize { get; set; }

                        /// <summary>
                        /// <para>The standard storage usage.</para>
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
                /// <para>The lifecycle properties of tables.</para>
                /// </summary>
                [NameInMap("tableLifecycle")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesTableLifecycle TableLifecycle { get; set; }
                public class GetProjectResponseBodyDataPropertiesTableLifecycle : TeaModel {
                    /// <summary>
                    /// <para>The lifecycle type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>mandatory</b>: The Lifecycle clause is mandatory. Users must set the table lifecycle.</description></item>
                    /// <item><description><b>optional</b>: The Lifecycle clause is optional when creating a table. If the table lifecycle is not set, the table is permanently valid.</description></item>
                    /// <item><description><b>inherit</b>: If the table lifecycle is not set when creating a table, the table lifecycle defaults to the value of odps.table.lifecycle.value.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>optional</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The table lifecycle in days. Valid values: 1 to 37231. Default value: 37231.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>37231</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/tiered-storage#f61fc9db76nna">tiered storage lifecycle rules</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/tiered-storage#f61fc9db76nna">tiered storage lifecycle rules</a> properties. After configuration, the system will trigger automatic storage tier conversion based on these rules.</para>
                /// </summary>
                [NameInMap("tableLifecycleConfig")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesTableLifecycleConfig TableLifecycleConfig { get; set; }
                public class GetProjectResponseBodyDataPropertiesTableLifecycleConfig : TeaModel {
                    /// <summary>
                    /// <para>The long-term storage identifier.</para>
                    /// </summary>
                    [NameInMap("TierToLongterm")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLongterm TierToLongterm { get; set; }
                    public class GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLongterm : TeaModel {
                        /// <summary>
                        /// <para>The number of days after the last data access before automatic conversion, corresponding to the <c>LastAccessTime</c> of the table or partition.</para>
                        /// <remarks>
                        /// <para>If the LastAccessTime of the table or partition is empty:</para>
                        /// <list type="bullet">
                        /// <item><description>For tables or partitions created before October 1, 2023, the default time is 2023.10.01 00:00:00 in the UTC+0 timezone.</description></item>
                        /// <item><description>For tables or partitions created after October 1, 2023, if the data has not been accessed, the CreateTime is used for calculation.</description></item>
                        /// </list>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>180</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastAccessGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastAccessGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The number of days after the last data modification before automatic conversion, corresponding to the <c>LastModifiedTime</c> of the table or partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>180</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastModificationGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The number of days since the last storage tier conversion.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastTierModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastTierModificationGreaterThan { get; set; }

                    }

                    /// <summary>
                    /// <para>The infrequent access storage identifier.</para>
                    /// </summary>
                    [NameInMap("TierToLowFrequency")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLowFrequency TierToLowFrequency { get; set; }
                    public class GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLowFrequency : TeaModel {
                        /// <summary>
                        /// <para>The number of days after the last data access before automatic conversion, corresponding to the <c>LastAccessTime</c> of the table or partition.</para>
                        /// <remarks>
                        /// <para>If the LastAccessTime of the table or partition is empty:</para>
                        /// <list type="bullet">
                        /// <item><description>For tables or partitions created before October 1, 2023, the default time is 2023.10.01 00:00:00 in the UTC+0 timezone.</description></item>
                        /// <item><description>For tables or partitions created after October 1, 2023, if the data has not been accessed, the CreateTime is used for calculation.</description></item>
                        /// </list>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastAccessGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastAccessGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The number of days after the last data modification before automatic conversion, corresponding to the <c>LastModifiedTime</c> of the table or partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastModificationGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The number of days since the last storage tier conversion.</para>
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
                /// <para>The project timezone, which is the <c>odps.sql.timezone</c> property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <para>The &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/overview-of-dts">Data Transfer Service</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/overview-of-dts">Data Transfer Service</a> resource group bound to the project.</para>
                /// <list type="bullet">
                /// <item><description><para>Default (Data Transfer Service shared resource group): This project is not allowed to use the Data Transfer Service (subscription) resource group. Regardless of the default Data Transfer Service resource group setting, Data Transfer Service tasks submitted by this project will automatically use the Default resource group.</para>
                /// </description></item>
                /// <item><description><para>Data Transfer Service (subscription) resource group: This project is allowed to use the Data Transfer Service (subscription) resource group.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("tunnelQuota")]
                [Validation(Required=false)]
                public string TunnelQuota { get; set; }

                /// <summary>
                /// <para>The data type edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Edition 1.0.</description></item>
                /// <item><description><b>2</b>: Edition 2.0.</description></item>
                /// <item><description><b>hive</b>: Hive-compatible type.</description></item>
                /// </list>
                /// <para>For differences among the three data type editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/data-type-editions">Data Type Editions</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/data-type-editions">Data Type Editions</a>.</para>
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
            /// <para>The instance ID and billing type of the default computing quota.</para>
            /// </summary>
            [NameInMap("saleTag")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataSaleTag SaleTag { get; set; }
            public class GetProjectResponseBodyDataSaleTag : TeaModel {
                /// <summary>
                /// <para>The instance ID of the default computing quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b7afb7d1-<b><b>-</b></b>-****-c393669c307b</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The billing type of the default computing quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
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
                /// <para>Whether the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/download-control">download control</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/label-based-access-control">download control</a> feature is enabled. It is disabled by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enableDownloadPrivilege")]
                [Validation(Required=false)]
                public bool? EnableDownloadPrivilege { get; set; }

                /// <summary>
                /// <para>Whether the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/label-based-access-control">label-based access control</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/label-based-access-control">label-based access control</a> feature is enabled. It is disabled by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("labelSecurity")]
                [Validation(Required=false)]
                public bool? LabelSecurity { get; set; }

                /// <summary>
                /// <para>Whether the object creator is allowed to have access permissions on the object. This is allowed by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("objectCreatorHasAccessPermission")]
                [Validation(Required=false)]
                public bool? ObjectCreatorHasAccessPermission { get; set; }

                /// <summary>
                /// <para>Whether the object creator is allowed to have grant permissions on the object. This is allowed by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("objectCreatorHasGrantPermission")]
                [Validation(Required=false)]
                public bool? ObjectCreatorHasGrantPermission { get; set; }

                /// <summary>
                /// <para>The &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/security-and-compliance/project-data-protection">data protection</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/project-data-protection">data protection</a> properties.</para>
                /// </summary>
                [NameInMap("projectProtection")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                public class GetProjectResponseBodyDataSecurityPropertiesProjectProtection : TeaModel {
                    /// <summary>
                    /// <para>If project data protection is enabled, you can set exceptions or trusted projects to allow specified users to export data of specified objects to specified projects. All scenarios described in the Exception Policy can override the data protection mechanism.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///       &quot;Version&quot;: &quot;1&quot;,
                    ///       &quot;Statement&quot;: [
                    ///             {
                    ///                   &quot;Effect&quot;: &quot;Allow&quot;,
                    ///                   &quot;Principal&quot;: &quot;&quot;,
                    ///                   &quot;Action&quot;: [
                    ///                         &quot;odps:[, , ...]&quot;
                    ///                   ],
                    ///                   &quot;Resource&quot;: &quot;acs:odps:*:&quot;,
                    ///                   &quot;Condition&quot;: {
                    ///                         &quot;StringEquals&quot;: {
                    ///                               &quot;odps:TaskType&quot;: [
                    ///                                     &quot;&quot;
                    ///                               ]
                    ///                         }
                    ///                   }
                    ///             }
                    ///       ]
                    /// }</para>
                    /// </summary>
                    [NameInMap("exceptionPolicy")]
                    [Validation(Required=false)]
                    public string ExceptionPolicy { get; set; }

                    /// <summary>
                    /// <para>Whether the project &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a> is enabled to prohibit or allow data to flow out of the project. It is disabled by default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("protected")]
                    [Validation(Required=false)]
                    public bool? Protected { get; set; }

                }

                /// <summary>
                /// <para>Whether the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/acl-based-access-control">ACL-based access control</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/acl-based-access-control">ACL-based access control</a> feature is enabled. It is enabled by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("usingAcl")]
                [Validation(Required=false)]
                public bool? UsingAcl { get; set; }

                /// <summary>
                /// <para>Whether the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/policy-based-access-control-1">policy-based access control</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/policy-based-access-control-1">policy-based access control</a> feature is enabled. It is enabled by default.</para>
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
            /// <item><description><b>AVAILABLE</b>: normal.</description></item>
            /// <item><description><b>READONLY</b>: read-only.</description></item>
            /// <item><description><b>FROZEN</b>: frozen.</description></item>
            /// <item><description><b>DELETING</b>: being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of members with the <c>Super_Administrator</c> role in the project.</para>
            /// </summary>
            [NameInMap("superAdmins")]
            [Validation(Required=false)]
            public List<string> SuperAdmins { get; set; }

            /// <summary>
            /// <para>Whether schema-based storage is supported.
            /// MaxCompute supports Schema, which is an object between Project and Table/Resource/UDF for categorizing Tables, Resources, and UDFs. A Project can contain multiple Schemas. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/user-guide/schema-related-operations">Schema Operations</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/schema-related-operations">Schema Operations</a>.</para>
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
            /// <item><description><b>managed</b>: internal project.</description></item>
            /// <item><description><b>external</b>: external project.</description></item>
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
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This object does not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description>1xx: Informational response - The request has been received and is being processed.</description></item>
        /// <item><description>2xx: Success - The request has been successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: Redirection - The request has been redirected. Further action is required to complete the request.</description></item>
        /// <item><description>4xx: Client error - The request contains incorrect parameters, syntax errors, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: Server error - The server is unable to fulfill the request due to other reasons.</description></item>
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
