// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyData Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A pagination token. Only continuous page turning is supported. If NextToken is not empty, the next page exists. The value of NextToken can be used in the next request to retrieve a new page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kvikyUl3ChyRxN+qLPvtOb</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>Indicates the marker after which the returned list begins.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
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
                /// <para>maxcompute projects</para>
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
                /// <para>The default computing quota that is used to allocate computing resources. If you do not specify a computing quota for your project, the jobs that are initiated by your project consume the computing resources in the default quota. For more information about how to use computing resources, see <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/use-of-computing-resources">Use quota groups for computing resources</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>quotaA</para>
                /// </summary>
                [NameInMap("defaultQuota")]
                [Validation(Required=false)]
                public string DefaultQuota { get; set; }

                /// <summary>
                /// <para>The information about the IP address whitelist.</para>
                /// </summary>
                [NameInMap("ipWhiteList")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsIpWhiteList IpWhiteList { get; set; }
                public class ListProjectsResponseBodyDataProjectsIpWhiteList : TeaModel {
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
                /// <para>The name of the project.</para>
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
                /// <para>1139815775606813</para>
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
                    /// <para>Indicates whether a full table scan is allowed in the project. A full table scan occupies a large number of resources, which reduces data processing efficiency. By default, the full table scan feature is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("allowFullScan")]
                    [Validation(Required=false)]
                    public bool? AllowFullScan { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the DECIMAL type of the MaxCompute V2.0 data type edition is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableDecimal2")]
                    [Validation(Required=false)]
                    public bool? EnableDecimal2 { get; set; }

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
                    public ListProjectsResponseBodyDataProjectsPropertiesEncryption Encryption { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesEncryption : TeaModel {
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
                    public ListProjectsResponseBodyDataProjectsPropertiesExternalProjectProperties ExternalProjectProperties { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesExternalProjectProperties : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the external project is an external project for <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/lake-warehouse-integrated-2-0-use-guide">data lakehouse solution 2.0</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("isExternalCatalogBound")]
                        [Validation(Required=false)]
                        public string IsExternalCatalogBound { get; set; }

                    }

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
                    /// <para>The table lifecycle properties.</para>
                    /// </summary>
                    [NameInMap("tableLifecycle")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsPropertiesTableLifecycle TableLifecycle { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesTableLifecycle : TeaModel {
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
                    /// <para>quota_tunnel</para>
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
                /// <para>The instance ID and billing method of the default computing quota.</para>
                /// </summary>
                [NameInMap("saleTag")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsSaleTag SaleTag { get; set; }
                public class ListProjectsResponseBodyDataProjectsSaleTag : TeaModel {
                    /// <summary>
                    /// <para>The instance ID of the default computing quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;aaaa-bbbb&quot;</para>
                    /// </summary>
                    [NameInMap("resourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The billing method of the default computing quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;project&quot;</para>
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
                public ListProjectsResponseBodyDataProjectsSecurityProperties SecurityProperties { get; set; }
                public class ListProjectsResponseBodyDataProjectsSecurityProperties : TeaModel {
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
                    public ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                    public class ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection : TeaModel {
                        /// <summary>
                        /// <para>If you enable the project data protection mechanism, you can configure exception or trusted projects. This allows specified users to transfer data of a specified object to a specified project. The project data protection mechanism does not take effect in all the situations that are specified in the exception policy.</para>
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
                /// <para>Indicates whether data storage by schema is supported. MaxCompute supports the schema feature. This feature allows you to classify objects such as tables, resources, and user-defined functions (UDFs) in a project by schema. You can create multiple schemas in a project. For more information, see <a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/schema-related-operations">Schema-related operations</a>.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: supported</description></item>
                /// <item><description>false: not supported</description></item>
                /// </list>
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
