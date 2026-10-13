// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyData Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination token. The current operation only supports sequential pagination. A non-empty nextToken value indicates that more data is available. You can use the nextToken value as a parameter to query the next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kvikyUl3ChyRxN+qLPvtOb</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The marker used to specify the starting point of the returned results. The results are sorted in alphabetical order and returned starting from the first item after the marker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>The maximum number of results to return per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

            /// <summary>
            /// <para>The list of projects.</para>
            /// </summary>
            [NameInMap("projects")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyDataProjects> Projects { get; set; }
            public class ListProjectsResponseBodyDataProjects : TeaModel {
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
                /// <para>The total storage size. This value indicates the current storage size of the project and is consistent with the billing metric. It represents the logical storage size after data compression at the project level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16489027</para>
                /// </summary>
                [NameInMap("costStorage")]
                [Validation(Required=false)]
                public string CostStorage { get; set; }

                /// <summary>
                /// <para>The creation time. The time is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1704380838000</para>
                /// </summary>
                [NameInMap("createdTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The default compute quota.
                /// This is used to allocate compute resources. If no compute quota is specified, jobs initiated in the project consume resources from the default quota. For more information about how to use compute resources, see &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/use-of-computing-resources">Use of computing resources</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/use-of-computing-resources">Use of computing resources</a>.</para>
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
                public ListProjectsResponseBodyDataProjectsIpWhiteList IpWhiteList { get; set; }
                public class ListProjectsResponseBodyDataProjectsIpWhiteList : TeaModel {
                    /// <summary>
                    /// <para>The IP address whitelist for the Internet and cloud service interconnection network.</para>
                    /// <remarks>
                    /// <para>If you configure only the IP address whitelist for the Internet and cloud service interconnection network, access from the Internet and cloud service interconnection network is restricted by the configuration, and all access from VPCs is prohibited.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.88.111.3</para>
                    /// </summary>
                    [NameInMap("ipList")]
                    [Validation(Required=false)]
                    public string IpList { get; set; }

                    /// <summary>
                    /// <para>The IP address whitelist for VPCs.</para>
                    /// <remarks>
                    /// <para>If you configure only the IP address whitelist for VPCs, access from VPCs is restricted by the configuration, and all access from the Internet and cloud service interconnection network is prohibited.</para>
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
                /// <para>The basic properties of the project.</para>
                /// </summary>
                [NameInMap("properties")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsProperties Properties { get; set; }
                public class ListProjectsResponseBodyDataProjectsProperties : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow full table scans in the project. Full table scans consume a large amount of resources. To improve processing efficiency, this feature is disabled by default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("allowFullScan")]
                    [Validation(Required=false)]
                    public bool? AllowFullScan { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable the DECIMAL data type of MaxCompute V2.0 for the project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableDecimal2")]
                    [Validation(Required=false)]
                    public bool? EnableDecimal2 { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable EPS resource group routing for the data transfer service.</para>
                    /// <list type="bullet">
                    /// <item><description>true: Data transfer tasks submitted by default in the project use the bound EPS resource group for the data transfer service.</description></item>
                    /// <item><description>false: Data transfer tasks submitted by default in the project use the shared EPS resource group for the data transfer service.</description></item>
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
                    public ListProjectsResponseBodyDataProjectsPropertiesEncryption Encryption { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesEncryption : TeaModel {
                        /// <summary>
                        /// <para>The data encryption algorithm. The encryption algorithms supported by the key include AES256, AESCTR, and RC4.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AES256</para>
                        /// </summary>
                        [NameInMap("algorithm")]
                        [Validation(Required=false)]
                        public string Algorithm { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to enable data encryption for the project. For more information about data encryption, see 
                        /// &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/security-and-compliance/storage-encryption">Storage encryption</a>
                        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/storage-encryption">Storage encryption</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>The type of the key used for data encryption. Valid values include the default key (MaxCompute Default Key) and Bring Your Own Key (BYOK). The default key is a default key created internally by MaxCompute.</para>
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
                    public ListProjectsResponseBodyDataProjectsPropertiesExternalProjectProperties ExternalProjectProperties { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesExternalProjectProperties : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the project is an external project of &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/lake-warehouse-integrated-2-0-use-guide">Data Lakehouse Solution 2.0</a>
                        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/lake-warehouse-integrated-2-0-use-guide">Data Lakehouse Solution 2.0</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("isExternalCatalogBound")]
                        [Validation(Required=false)]
                        public string IsExternalCatalogBound { get; set; }

                    }

                    /// <summary>
                    /// <para>The retention period of backup data in days. During this period, you can restore the current version to any backed-up data version. Valid values: 0 to 30. Default value: 1. A value of 0 indicates that the backup feature is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("retentionDays")]
                    [Validation(Required=false)]
                    public long? RetentionDays { get; set; }

                    /// <summary>
                    /// <para>The maximum threshold for the consumption of a single SQL statement. Unit: scanned data volume (GB) × complexity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1500</para>
                    /// </summary>
                    [NameInMap("sqlMeteringMax")]
                    [Validation(Required=false)]
                    public string SqlMeteringMax { get; set; }

                    /// <summary>
                    /// <para>The lifecycle properties of tables.</para>
                    /// </summary>
                    [NameInMap("tableLifecycle")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsPropertiesTableLifecycle TableLifecycle { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesTableLifecycle : TeaModel {
                        /// <summary>
                        /// <para>The lifecycle type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>mandatory</b>: The LIFECYCLE clause is required. You must specify a lifecycle for the table.</description></item>
                        /// <item><description><b>optional</b>: The LIFECYCLE clause is optional when you create a table. If you do not specify a lifecycle for the table, the table never expires.</description></item>
                        /// <item><description><b>inherit</b>: If you do not specify a lifecycle for a table when you create the table, the lifecycle of the table is the value of the odps.table.lifecycle.value parameter.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>optional</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The lifecycle of the table. Unit: days. Valid values: 1 to 37231. Default value: 37231.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>37231</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The time zone of the project, which is the odps.sql.timezone property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                    /// <summary>
                    /// <para>The EPS resource group of the &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/overview-of-dts">data transfer service</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/overview-of-dts">data transfer service</a> bound to the project.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Default (shared EPS resource group for the data transfer service): The project is not allowed to use the subscription EPS resource group for the data transfer service. Regardless of the default EPS resource group setting, data transfer tasks submitted by default in this project automatically use the Default EPS resource group.</para>
                    /// </description></item>
                    /// <item><description><para>Subscription EPS resource group for the data transfer service: The project is allowed to use the subscription EPS resource group for the data transfer service.</para>
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
                    /// <item><description><b>1</b>: MaxCompute V1.0 data type edition</description></item>
                    /// <item><description><b>2</b>: MaxCompute V2.0 data type edition</description></item>
                    /// <item><description><b>hive</b>: Hive-compatible data type edition</description></item>
                    /// </list>
                    /// <para>For more information about the differences among the three data type editions, see &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/data-type-editions">Data type editions</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/data-type-editions">Data type editions</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
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
                /// <para>The instance ID and billing method of the default compute quota.</para>
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsSaleTag SaleTag { get; set; }
                public class ListProjectsResponseBodyDataProjectsSaleTag : TeaModel {
                    /// <summary>
                    /// <para>The instance ID of the default compute quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>b7afb7d1-<b><b>-</b></b>-****-c393669c307b</para>
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The billing method of the default compute quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayAsYouGo</para>
                    /// </summary>
                    [NameInMap("resourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// <para>The security properties.</para>
                /// </summary>
                [NameInMap("securityProperties")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsSecurityProperties SecurityProperties { get; set; }
                public class ListProjectsResponseBodyDataProjectsSecurityProperties : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to use the &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/download-control">download control</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/label-based-access-control">download control</a> feature. By default, this feature is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("enableDownloadPrivilege")]
                    [Validation(Required=false)]
                    public bool? EnableDownloadPrivilege { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to use the &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/label-based-access-control">label-based access control</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/label-based-access-control">label-based access control</a> feature. By default, this feature is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("labelSecurity")]
                    [Validation(Required=false)]
                    public bool? LabelSecurity { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to allow object creators to have access permissions on the objects. By default, this is allowed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("objectCreatorHasAccessPermission")]
                    [Validation(Required=false)]
                    public bool? ObjectCreatorHasAccessPermission { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to allow object creators to have authorization permissions on the objects. By default, this is allowed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("objectCreatorHasGrantPermission")]
                    [Validation(Required=false)]
                    public bool? ObjectCreatorHasGrantPermission { get; set; }

                    /// <summary>
                    /// <para>The &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a> properties.</para>
                    /// </summary>
                    [NameInMap("projectProtection")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                    public class ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection : TeaModel {
                        /// <summary>
                        /// <para>If you enable data protection for the project, you can configure exceptions or trusted projects to allow specified users to transfer data of specified objects to specified projects. All scenarios described in the exception policy can bypass the data protection mechanism.</para>
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
                        /// <para>Specifies whether to enable the &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a>
                        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/project-data-protection">data protection mechanism</a> for the project to prohibit or allow data stream out of the project. The default enabling status is disabled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("protected")]
                        [Validation(Required=false)]
                        public bool? Protected { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to use the &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/acl-based-access-control">ACL-based access control</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/acl-based-access-control">ACL-based access control</a> feature. By default, this feature is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("usingAcl")]
                    [Validation(Required=false)]
                    public bool? UsingAcl { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to use the &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/policy-based-access-control-1">policy-based access control</a>
                    /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/policy-based-access-control-1">policy-based access control</a> feature. By default, this feature is enabled.</para>
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
                /// <item><description><b>AVAILABLE</b>: normal</description></item>
                /// <item><description><b>READONLY</b>: read-only</description></item>
                /// <item><description><b>FROZEN</b>: frozen</description></item>
                /// <item><description><b>DELETING</b>: deleting</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Specifies whether to support schema-based storage.
                /// MaxCompute supports schemas, which are located under projects and used to classify objects such as tables, resources, and UDFs. A project can contain multiple schemas. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/schema-related-operations">Schema-related operations</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/schema-related-operations">Schema-related operations</a>.</para>
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

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b16399216671970335563173e2340</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
