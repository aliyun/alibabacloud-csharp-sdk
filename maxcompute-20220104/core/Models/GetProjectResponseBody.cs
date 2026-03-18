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
            /// <para>BI_Analysis</para>
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The total storage usage. This value indicates the logical storage size after data is collected and compressed for the project. The storage usage is the same as the usage for billing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16489027</para>
            /// </summary>
            [NameInMap("costStorage")]
            [Validation(Required=false)]
            public string CostStorage { get; set; }

            /// <summary>
            /// <para>The time when the project was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1704380838000</para>
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The default computing quota. Quotas are used for resource allocation. If you do not specify a computing quota, jobs that are initiated in the project consume resources from the default quota. For more information, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/use-of-computing-resources">Use of computing resources</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os_PayAsYouGoQuota</para>
            /// </summary>
            [NameInMap("defaultQuota")]
            [Validation(Required=false)]
            public string DefaultQuota { get; set; }

            /// <summary>
            /// <para>The IP address whitelist.</para>
            /// </summary>
            [NameInMap("ipWhiteList")]
            [Validation(Required=false)]
            public GetProjectResponseBodyDataIpWhiteList IpWhiteList { get; set; }
            public class GetProjectResponseBodyDataIpWhiteList : TeaModel {
                /// <summary>
                /// <para>The IP address whitelist for access over the Internet or a network that is used to interconnect with other Alibaba Cloud services.</para>
                /// <remarks>
                /// <para>If you configure only this IP address whitelist, access over the Internet or the network that is used to interconnect with other Alibaba Cloud services is restricted based on the configuration, and access over a VPC is prohibited.</para>
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
                /// <para>If you configure only this IP address whitelist, access over a VPC is restricted based on the configuration, and access over the Internet or a network that is used to interconnect with other Alibaba Cloud services is prohibited.</para>
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
                /// <para>Specifies whether to allow a full table scan in the project. A full table scan consumes a large amount of resources and reduces processing efficiency. By default, this feature is disabled.</para>
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
                /// <para>The parent resource group of the Data Transmission Service resource group that is bound to the project. This parameter is for internal use.</para>
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

                /// <summary>
                /// <para>Specifies whether to enable the DECIMAL data type of MaxCompute V2.0 for the project.</para>
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
                /// <para>Specifies whether to forcefully enable external table caching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableFdcCacheForce")]
                [Validation(Required=false)]
                public bool? EnableFdcCacheForce { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/tiered-storage">tiered storage</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableTieredStorage")]
                [Validation(Required=false)]
                public bool? EnableTieredStorage { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable routing for the Data Transmission Service resource group.</para>
                /// <list type="bullet">
                /// <item><description><para>true: The data transmission tasks that are submitted by default in the project use the Data Transmission Service resource group that is bound to the project.</para>
                /// </description></item>
                /// <item><description><para>false: The data transmission tasks that are submitted by default in the project use the shared Data Transmission Service resource group.</para>
                /// </description></item>
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
                    /// <para>The data encryption algorithm. Supported algorithms include AES256, AESCTR, and RC4.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AES256</para>
                    /// </summary>
                    [NameInMap("algorithm")]
                    [Validation(Required=false)]
                    public string Algorithm { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable data encryption for the project. For more information, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/security-and-compliance/storage-encryption">Storage encryption</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The type of key used for data encryption. Valid values include MaxCompute Default Key and Bring-Your-Own-Key (BYOK). MaxCompute Default Key is a default key created within MaxCompute.</para>
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
                    /// <para>Specifies whether the project is an external project of &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/lake-warehouse-integrated-2-0-use-guide">data lakehouse 2.0</a>.</para>
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
                /// <para>The retention period of backup data. Unit: days. During this period, you can restore the current data version to any backup version. The value can be an integer from 0 to 30. The default value is 1. A value of 0 indicates that the backup feature is disabled.</para>
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
                /// <para>The &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/tiered-storage">tiered storage</a> information.</para>
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
                    /// <para>The &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/tiered-storage">tiered storage</a> information.</para>
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
                        /// <para>The IA storage class usage.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>767693</para>
                        /// </summary>
                        [NameInMap("lowFrequencySize")]
                        [Validation(Required=false)]
                        public long? LowFrequencySize { get; set; }

                        /// <summary>
                        /// <para>The Standard storage usage.</para>
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
                /// <para>The lifecycle properties of the table.</para>
                /// </summary>
                [NameInMap("tableLifecycle")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesTableLifecycle TableLifecycle { get; set; }
                public class GetProjectResponseBodyDataPropertiesTableLifecycle : TeaModel {
                    /// <summary>
                    /// <para>The lifecycle type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>mandatory</b>: The Lifecycle clause is required. You must set a lifecycle for the table.</para>
                    /// </description></item>
                    /// <item><description><para><b>optional</b>: The Lifecycle clause is optional when you create a table. If you do not set a lifecycle for the table, the table is permanently valid.</para>
                    /// </description></item>
                    /// <item><description><para><b>inherit</b>: If you do not set a lifecycle for a table when you create it, the lifecycle of the table is the value of odps.table.lifecycle.value.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>optional</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The lifecycle of the table. Unit: days. The value can be an integer from 1 to 37231. The default value is 37231.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>37231</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The properties of the &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/tiered-storage#f61fc9db76nna">tiered storage lifecycle rule</a>. After you set these properties, the system automatically triggers the conversion of storage classes based on the rule.</para>
                /// </summary>
                [NameInMap("tableLifecycleConfig")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataPropertiesTableLifecycleConfig TableLifecycleConfig { get; set; }
                public class GetProjectResponseBodyDataPropertiesTableLifecycleConfig : TeaModel {
                    /// <summary>
                    /// <para>The identifier for the long-term storage class.</para>
                    /// </summary>
                    [NameInMap("TierToLongterm")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLongterm TierToLongterm { get; set; }
                    public class GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLongterm : TeaModel {
                        /// <summary>
                        /// <para>The number of days after the data was last accessed. After this period, the storage class is automatically changed. This corresponds to the <c>LastAccessTime</c> of the table or partition.</para>
                        /// <remarks>
                        /// <para>If the LastAccessTime of the table or partition is empty:</para>
                        /// <list type="bullet">
                        /// <item><description><para>For tables or partitions that were created before October 1, 2023, the last access time is considered 00:00:00 on October 1, 2023 (UTC+0).</para>
                        /// </description></item>
                        /// <item><description><para>For tables or partitions that were created on or after October 1, 2023, if the data has not been accessed, the creation time of the table or partition is considered the last access time.</para>
                        /// </description></item>
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
                        /// <para>The number of days after the data was last modified. After this period, the storage class is automatically changed. This corresponds to the <c>LastModifiedTime</c> of the table or partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>180</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastModificationGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The number of days after the storage class was last changed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastTierModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastTierModificationGreaterThan { get; set; }

                    }

                    /// <summary>
                    /// <para>The identifier for the IA storage class.</para>
                    /// </summary>
                    [NameInMap("TierToLowFrequency")]
                    [Validation(Required=false)]
                    public GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLowFrequency TierToLowFrequency { get; set; }
                    public class GetProjectResponseBodyDataPropertiesTableLifecycleConfigTierToLowFrequency : TeaModel {
                        /// <summary>
                        /// <para>The number of days after the data was last accessed. After this period, the storage class is automatically changed. This corresponds to the <c>LastAccessTime</c> of the table or partition.</para>
                        /// <remarks>
                        /// <para>If the LastAccessTime of the table or partition is empty:</para>
                        /// <list type="bullet">
                        /// <item><description><para>For tables or partitions that were created before October 1, 2023, the last access time is considered 00:00:00 on October 1, 2023 (UTC+0).</para>
                        /// </description></item>
                        /// <item><description><para>For tables or partitions that were created on or after October 1, 2023, if the data has not been accessed, the creation time of the table or partition is considered the last access time.</para>
                        /// </description></item>
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
                        /// <para>The number of days after the data was last modified. After this period, the storage class is automatically changed. This corresponds to the <c>LastModifiedTime</c> of the table or partition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("DaysAfterLastModificationGreaterThan")]
                        [Validation(Required=false)]
                        public long? DaysAfterLastModificationGreaterThan { get; set; }

                        /// <summary>
                        /// <para>The number of days after the storage class was last changed.</para>
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
                /// <para>The time zone of the project. This parameter corresponds to the <c>odps.sql.timezone</c> property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <para>The &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/overview-of-dts">Data Transmission Service</a> resource group that is bound to the project.</para>
                /// <list type="bullet">
                /// <item><description><para>Default (shared Data Transmission Service resource group): The project cannot use a subscription Data Transmission Service resource group. Regardless of the value of the default Data Transmission Service resource group, the Data Transmission Service automatically uses the Default resource group for data transmission tasks that are submitted by default in the project.</para>
                /// </description></item>
                /// <item><description><para>Subscription Data Transmission Service resource group: The project can use a subscription Data Transmission Service resource group.</para>
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
                /// <item><description><para><b>1</b>: V1.0</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: V2.0</para>
                /// </description></item>
                /// <item><description><para><b>hive</b>: Hive-compatible</para>
                /// </description></item>
                /// </list>
                /// <para>For more information, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/data-type-editions">Data type editions</a>.</para>
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
                /// <para>b7afb7d1-<b><b>-</b></b>-****-c393669c307b</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The billing method of the default computing quota.</para>
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
                /// <para>Specifies whether to use the &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/download-control">download control</a> feature. By default, this feature is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enableDownloadPrivilege")]
                [Validation(Required=false)]
                public bool? EnableDownloadPrivilege { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/label-based-access-control">label-based access control</a> feature. By default, this feature is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("labelSecurity")]
                [Validation(Required=false)]
                public bool? LabelSecurity { get; set; }

                /// <summary>
                /// <para>Specifies whether the creator of an object has access permissions on the object. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("objectCreatorHasAccessPermission")]
                [Validation(Required=false)]
                public bool? ObjectCreatorHasAccessPermission { get; set; }

                /// <summary>
                /// <para>Specifies whether the creator of an object has grant permissions on the object. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("objectCreatorHasGrantPermission")]
                [Validation(Required=false)]
                public bool? ObjectCreatorHasGrantPermission { get; set; }

                /// <summary>
                /// <para>The properties of the &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a>.</para>
                /// </summary>
                [NameInMap("projectProtection")]
                [Validation(Required=false)]
                public GetProjectResponseBodyDataSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                public class GetProjectResponseBodyDataSecurityPropertiesProjectProtection : TeaModel {
                    /// <summary>
                    /// <para>If data protection is enabled for a project, you can configure an exception policy to specify exception or trusted projects. This policy allows specified users to transfer data from a specified object to a specified project. The data protection mechanism does not apply to the scenarios described in the exception policy.</para>
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
                    /// <para>Specifies whether to enable the &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a> for the project to prohibit or allow data to flow out of the project. By default, this mechanism is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("protected")]
                    [Validation(Required=false)]
                    public bool? Protected { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to use the &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/acl-based-access-control">ACL-based access control</a> feature. By default, this feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("usingAcl")]
                [Validation(Required=false)]
                public bool? UsingAcl { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/policy-based-access-control-1">policy-based access control</a> feature. By default, this feature is enabled.</para>
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
            /// <item><description><para><b>AVAILABLE</b>: Normal</para>
            /// </description></item>
            /// <item><description><para><b>READONLY</b>: read-only</para>
            /// </description></item>
            /// <item><description><para><b>FROZEN</b>: frozen</para>
            /// </description></item>
            /// <item><description><para><b>DELETING</b>: being deleted</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of members that are assigned the <c>Super_Administrator</c> role in the project.</para>
            /// </summary>
            [NameInMap("superAdmins")]
            [Validation(Required=false)]
            public List<string> SuperAdmins { get; set; }

            /// <summary>
            /// <para>Specifies whether data storage by schema is supported. MaxCompute supports schemas. A schema is an object in a project. It is used to classify objects such as tables, resources, and user-defined functions (UDFs). You can create multiple schemas in a project. For more information, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/schema-related-operations">Schema operations</a>.</para>
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
            /// <item><description><para><b>managed</b>: an internal project.</para>
            /// </description></item>
            /// <item><description><para><b>external</b>: an external project.</para>
            /// </description></item>
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
        /// <item><description><para>1xx: Informational response. The request is received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: Success. The request is successfully received, understood, and accepted by the server.</para>
        /// </description></item>
        /// <item><description><para>3xx: Redirection. The request is redirected, and further actions are required to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: Client error. The request contains invalid request parameters or syntax, or specific request conditions cannot be met.</para>
        /// </description></item>
        /// <item><description><para>5xx: Server error. The server cannot fulfill the request for other reasons.</para>
        /// </description></item>
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
