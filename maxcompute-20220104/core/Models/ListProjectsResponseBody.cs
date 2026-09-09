// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyData Data { get; set; }
        public class ListProjectsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The token for retrieving the next page of results. If this parameter is empty, all results have been returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6kvikyUl3ChyRxN+qLPvtOb</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>A pagination marker used to retrieve the next page of results. This parameter is returned when the response is truncated.</para>
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
                /// <para>The description of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BI_Analysis</para>
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The total storage usage of the project, which represents the compressed, logical data size used for metering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16489027</para>
                /// </summary>
                [NameInMap("costStorage")]
                [Validation(Required=false)]
                public string CostStorage { get; set; }

                /// <summary>
                /// <para>The time when the project was created, as a Unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1704380838000</para>
                /// </summary>
                [NameInMap("createdTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The default compute quota. If you do not specify a quota for a job, the job consumes computing resources from this default quota. For more information about how to use computing resources, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/use-of-computing-resources">Use of computing resources</a>.</para>
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
                public ListProjectsResponseBodyDataProjectsIpWhiteList IpWhiteList { get; set; }
                public class ListProjectsResponseBodyDataProjectsIpWhiteList : TeaModel {
                    /// <summary>
                    /// <para>The IP whitelist for access over the public network and from other Alibaba Cloud services.</para>
                    /// <remarks>
                    /// <para>If you configure only this IP whitelist, access over the public network and from other Alibaba Cloud services is restricted based on the whitelist, and all access from VPCs is denied.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.88.111.3</para>
                    /// </summary>
                    [NameInMap("ipList")]
                    [Validation(Required=false)]
                    public string IpList { get; set; }

                    /// <summary>
                    /// <para>The IP whitelist for access from VPCs.</para>
                    /// <remarks>
                    /// <para>If you configure only the VPC IP whitelist, access from VPCs is restricted based on the whitelist, and all access over the public network and from other Alibaba Cloud services is denied.</para>
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
                /// <para>The owner of the project.</para>
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
                    /// <para>Specifies whether to allow a full table scan in the project. This feature is disabled by default because a full table scan can consume a large amount of computing resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("allowFullScan")]
                    [Validation(Required=false)]
                    public bool? AllowFullScan { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable the MaxCompute 2.0 Decimal data type in the project.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enableDecimal2")]
                    [Validation(Required=false)]
                    public bool? EnableDecimal2 { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable routing for the Data Transmission Service resource group.</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: Data transmission jobs submitted by default from the project use the bound Data Transmission Service resource group.</para>
                    /// </description></item>
                    /// <item><description><para>false: Data transmission jobs submitted by default from the project use the shared Data Transmission Service resource group.</para>
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
                    public ListProjectsResponseBodyDataProjectsPropertiesEncryption Encryption { get; set; }
                    public class ListProjectsResponseBodyDataProjectsPropertiesEncryption : TeaModel {
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
                        /// <para>Specifies whether to enable storage encryption for the project. For more information, see
                        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/storage-encryption">Storage encryption</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>The key for data encryption. You can use the default MaxCompute-managed key or a custom key with the Bring Your Own Key (BYOK) feature.</para>
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
                        /// <para>Specifies whether the project is an external project for &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/lake-warehouse-integrated-2-0-use-guide">Integrated Lakehouse</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("isExternalCatalogBound")]
                        [Validation(Required=false)]
                        public string IsExternalCatalogBound { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of retention days for backup data. You can restore data to any backup version that is created within the retention period. Valid values: <c>0</c> to <c>30</c>. Default value: <c>1</c>. A value of <c>0</c> indicates that the backup feature is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("retentionDays")]
                    [Validation(Required=false)]
                    public long? RetentionDays { get; set; }

                    /// <summary>
                    /// <para>The maximum metered cost for a single SQL statement. The cost is calculated by using the formula: (scanned data in GB) × (complexity).</para>
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
                        /// <para>The type of the lifecycle. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>mandatory</b>: A lifecycle must be configured for each table.</para>
                        /// </description></item>
                        /// <item><description><para><b>optional</b>: The lifecycle is optional. If unspecified for a table, the table does not expire.</para>
                        /// </description></item>
                        /// <item><description><para><b>inherit</b>: If no lifecycle is specified for a table, the table inherits its lifecycle from the <c>odps.table.lifecycle.value</c> property.</para>
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
                        /// <para>The lifecycle of the table, in days. Valid values: <c>1</c> to <c>37231</c>. Default value: <c>37231</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>37231</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

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
                    /// <para>The &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/overview-of-dts">Data Transmission Service</a> resource group that is bound to the project.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Default (shared Data Transmission Service resource group): The project cannot use subscription Data Transmission Service resource groups. Data Transmission Service jobs submitted from this project automatically use the Default resource group, regardless of the default setting for the Data Transmission Service resource group.</para>
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
                    /// <para>The data type version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>1</b>: Version 1.0.</para>
                    /// </description></item>
                    /// <item><description><para><b>2</b>: Version 2.0.</para>
                    /// </description></item>
                    /// <item><description><para><b>hive</b>: A Hive-compatible type.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>For more information about the differences between the data type versions, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/data-type-editions">Data type versions</a>.</para>
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
                /// <para>The security-related properties.</para>
                /// </summary>
                [NameInMap("securityProperties")]
                [Validation(Required=false)]
                public ListProjectsResponseBodyDataProjectsSecurityProperties SecurityProperties { get; set; }
                public class ListProjectsResponseBodyDataProjectsSecurityProperties : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/label-based-access-control">download control</a>. Default value: <c>false</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("enableDownloadPrivilege")]
                    [Validation(Required=false)]
                    public bool? EnableDownloadPrivilege { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/label-based-access-control">label-based access control</a>. Default value: <c>false</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("labelSecurity")]
                    [Validation(Required=false)]
                    public bool? LabelSecurity { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the creator of an object can access it. Default value: <c>true</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("objectCreatorHasAccessPermission")]
                    [Validation(Required=false)]
                    public bool? ObjectCreatorHasAccessPermission { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the creator of an object can grant other users permissions on it. Default value: <c>true</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("objectCreatorHasGrantPermission")]
                    [Validation(Required=false)]
                    public bool? ObjectCreatorHasGrantPermission { get; set; }

                    /// <summary>
                    /// <para>The &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/project-data-protection">project data protection</a> properties.</para>
                    /// </summary>
                    [NameInMap("projectProtection")]
                    [Validation(Required=false)]
                    public ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection ProjectProtection { get; set; }
                    public class ListProjectsResponseBodyDataProjectsSecurityPropertiesProjectProtection : TeaModel {
                        /// <summary>
                        /// <para>If project data protection is enabled, you can configure an exception policy. This policy allows specified users to export data from specified objects to trusted projects, bypassing the data protection mechanism.</para>
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
                        /// <para>Specifies whether to enable &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/security-and-compliance/project-data-protection">project data protection</a> to prevent data from being exported from the project. Default value: <c>false</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("protected")]
                        [Validation(Required=false)]
                        public bool? Protected { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to enable &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/acl-based-access-control">ACL-based access control</a>. Default value: <c>true</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("usingAcl")]
                    [Validation(Required=false)]
                    public bool? UsingAcl { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/policy-based-access-control-1">policy-based access control</a>. Default value: <c>true</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("usingPolicy")]
                    [Validation(Required=false)]
                    public bool? UsingPolicy { get; set; }

                }

                /// <summary>
                /// <para>The status of the project. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>AVAILABLE</b>: The project is running as expected.</para>
                /// </description></item>
                /// <item><description><para><b>READONLY</b>: The project is read-only.</para>
                /// </description></item>
                /// <item><description><para><b>FROZEN</b>: The project is frozen.</para>
                /// </description></item>
                /// <item><description><para><b>DELETING</b>: The project is being deleted.</para>
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
                /// <para>Specifies whether the project uses a three-tier model (project &gt; schema &gt; object). In this model, schemas are used within a project to organize objects such as tables, resources, and user-defined functions (UDFs). For more information, see &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/maxcompute/user-guide/schema-related-operations">Schema operations</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("threeTierModel")]
                [Validation(Required=false)]
                public bool? ThreeTierModel { get; set; }

                /// <summary>
                /// <para>The type of the project. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>managed</b>: An internal project.</para>
                /// </description></item>
                /// <item><description><para><b>external</b>: An external project.</para>
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
