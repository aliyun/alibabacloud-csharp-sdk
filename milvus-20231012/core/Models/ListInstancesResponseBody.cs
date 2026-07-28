// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details for an access denial error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;milvus:xxxx&quot; }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>An array of instance objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyData> Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic backup is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoBackup")]
            [Validation(Required=false)]
            public bool? AutoBackup { get; set; }

            /// <summary>
            /// <para>The creation time of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1718608505000</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>The instance details.</para>
            /// </summary>
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyDataClusterInfo ClusterInfo { get; set; }
            public class ListInstancesResponseBodyDataClusterInfo : TeaModel {
                /// <summary>
                /// <para>The Attu port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("AttuPort")]
                [Validation(Required=false)]
                public int? AttuPort { get; set; }

                /// <summary>
                /// <para>The public endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-123xxx.milvus.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InternetUrl")]
                [Validation(Required=false)]
                public string InternetUrl { get; set; }

                /// <summary>
                /// <para>The internal endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-123xxx-internal.milvus.aliyuncs.com</para>
                /// </summary>
                [NameInMap("IntranetUrl")]
                [Validation(Required=false)]
                public string IntranetUrl { get; set; }

                /// <summary>
                /// <para>A list of resource details for the instance\&quot;s components.</para>
                /// </summary>
                [NameInMap("MilvusResourceInfoList")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataClusterInfoMilvusResourceInfoList> MilvusResourceInfoList { get; set; }
                public class ListInstancesResponseBodyDataClusterInfoMilvusResourceInfoList : TeaModel {
                    /// <summary>
                    /// <para>The component type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>standalone</c></para>
                    /// </description></item>
                    /// <item><description><para><c>proxy</c></para>
                    /// </description></item>
                    /// <item><description><para><c>mix_coordinator</c></para>
                    /// </description></item>
                    /// <item><description><para><c>query</c></para>
                    /// </description></item>
                    /// <item><description><para><c>index</c></para>
                    /// </description></item>
                    /// <item><description><para><c>data</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>standalone</para>
                    /// </summary>
                    [NameInMap("ComponentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// <para>The number of CUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16</para>
                    /// </summary>
                    [NameInMap("CuNum")]
                    [Validation(Required=false)]
                    public int? CuNum { get; set; }

                    /// <summary>
                    /// <para>The disk size in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public int? DiskSize { get; set; }

                    /// <summary>
                    /// <para>The disk type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>essd</para>
                    /// </summary>
                    [NameInMap("DiskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    /// <summary>
                    /// <para>The number of replicas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Replica")]
                    [Validation(Required=false)]
                    public int? Replica { get; set; }

                }

                /// <summary>
                /// <para>The proxy port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19530</para>
                /// </summary>
                [NameInMap("ProxyPort")]
                [Validation(Required=false)]
                public int? ProxyPort { get; set; }

                /// <summary>
                /// <para>The total number of CUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("TotalCuNum")]
                [Validation(Required=false)]
                public int? TotalCuNum { get; set; }

                /// <summary>
                /// <para>The total disk size in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("TotalDiskSize")]
                [Validation(Required=false)]
                public int? TotalDiskSize { get; set; }

            }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>milvus-test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721232000000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-123xxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>creating</c>: The instance is being created.</para>
            /// </description></item>
            /// <item><description><para><c>running</c>: The instance is running.</para>
            /// </description></item>
            /// <item><description><para><c>updating</c>: The instance is being updated. This includes scaling the instance, changing configurations, or modifying public network access.</para>
            /// </description></item>
            /// <item><description><para><c>disable</c>: The instance is unavailable because it has expired and requires renewal.</para>
            /// </description></item>
            /// <item><description><para><c>deleting</c>: The instance is being deleted.</para>
            /// </description></item>
            /// <item><description><para><c>deleted</c>: The instance has been deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The node type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>perf</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>Indicates whether public network access is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpenPublicNet")]
            [Validation(Required=false)]
            public bool? OpenPublicNet { get; set; }

            /// <summary>
            /// <para>The instance edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>trial</c>: Trial Edition.</para>
            /// </description></item>
            /// <item><description><para><c>standard</c>: Standard Edition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>trial</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>0</c>: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: subscription.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>milvus_milvuspre_public_cn</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-123xxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The duration the instance has been running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>536611</para>
            /// </summary>
            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public int? RunningTime { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-123xxx</para>
            /// </summary>
            [NameInMap("SgId")]
            [Validation(Required=false)]
            public string SgId { get; set; }

            /// <summary>
            /// <para>The tags attached to the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataTags> Tags { get; set; }
            public class ListInstancesResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The template version.</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The instance version.</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-123xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-123xxx</para>
            /// </summary>
            [NameInMap("VswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to find instance c-123xxx</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABCD-1234-5678-EFGH</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of instances found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
