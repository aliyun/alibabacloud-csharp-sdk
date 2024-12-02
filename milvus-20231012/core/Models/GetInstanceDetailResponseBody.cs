// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class GetInstanceDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;milvus:xxxx&quot; }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceDetailResponseBodyData Data { get; set; }
        public class GetInstanceDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acl-123xxx</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1716863508000</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>milvus-test</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://oss.console.aliyun.com/bucket/oss-cn-beijing/xxxx/object?spm=a2cug.25127996.0.0.577990370Ebsqt&path=milvus-c-123xxxx">https://oss.console.aliyun.com/bucket/oss-cn-beijing/xxxx/object?spm=a2cug.25127996.0.0.577990370Ebsqt&amp;path=milvus-c-123xxxx</a></para>
            /// </summary>
            [NameInMap("BucketPath")]
            [Validation(Required=false)]
            public string BucketPath { get; set; }

            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public GetInstanceDetailResponseBodyDataClusterInfo ClusterInfo { get; set; }
            public class GetInstanceDetailResponseBodyDataClusterInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("AttuPort")]
                [Validation(Required=false)]
                public int? AttuPort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c-123xxx-.milvus.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InternetUrl")]
                [Validation(Required=false)]
                public string InternetUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c-123xxx-internal.milvus.aliyuncs.com</para>
                /// </summary>
                [NameInMap("IntranetUrl")]
                [Validation(Required=false)]
                public string IntranetUrl { get; set; }

                [NameInMap("MilvusResourceInfoList")]
                [Validation(Required=false)]
                public List<GetInstanceDetailResponseBodyDataClusterInfoMilvusResourceInfoList> MilvusResourceInfoList { get; set; }
                public class GetInstanceDetailResponseBodyDataClusterInfoMilvusResourceInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>QueryNode</para>
                    /// </summary>
                    [NameInMap("ComponentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("CuNum")]
                    [Validation(Required=false)]
                    public int? CuNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public int? DiskSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>essd</para>
                    /// </summary>
                    [NameInMap("DiskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Replica")]
                    [Validation(Required=false)]
                    public int? Replica { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>125.15 GB</para>
                /// </summary>
                [NameInMap("OssStorageSize")]
                [Validation(Required=false)]
                public string OssStorageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1718604000000</para>
                /// </summary>
                [NameInMap("OssStorageTimestamp")]
                [Validation(Required=false)]
                public long? OssStorageTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19530</para>
                /// </summary>
                [NameInMap("ProxyPort")]
                [Validation(Required=false)]
                public int? ProxyPort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("TotalCuNum")]
                [Validation(Required=false)]
                public int? TotalCuNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("TotalDiskSize")]
                [Validation(Required=false)]
                public int? TotalDiskSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun-test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("EnableHa")]
            [Validation(Required=false)]
            public bool? EnableHa { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1721664000000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c-123xxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("MeasureConfig")]
            [Validation(Required=false)]
            public GetInstanceDetailResponseBodyDataMeasureConfig MeasureConfig { get; set; }
            public class GetInstanceDetailResponseBodyDataMeasureConfig : TeaModel {
                [NameInMap("DataNodeCuNum")]
                [Validation(Required=false)]
                public int? DataNodeCuNum { get; set; }

                [NameInMap("DataNodeReplica")]
                [Validation(Required=false)]
                public int? DataNodeReplica { get; set; }

                [NameInMap("IndexNodeCuNum")]
                [Validation(Required=false)]
                public int? IndexNodeCuNum { get; set; }

                [NameInMap("IndexNodeReplica")]
                [Validation(Required=false)]
                public int? IndexNodeReplica { get; set; }

                [NameInMap("MixCoodinatorNodeCuNum")]
                [Validation(Required=false)]
                public int? MixCoodinatorNodeCuNum { get; set; }

                [NameInMap("MixCoodinatorNodeReplica")]
                [Validation(Required=false)]
                public int? MixCoodinatorNodeReplica { get; set; }

                [NameInMap("ProxyNodeCuNum")]
                [Validation(Required=false)]
                public int? ProxyNodeCuNum { get; set; }

                [NameInMap("ProxyNodeReplica")]
                [Validation(Required=false)]
                public int? ProxyNodeReplica { get; set; }

                [NameInMap("QueryNodeCuNum")]
                [Validation(Required=false)]
                public int? QueryNodeCuNum { get; set; }

                [NameInMap("QueryNodeReplica")]
                [Validation(Required=false)]
                public int? QueryNodeReplica { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpenPublicNet")]
            [Validation(Required=false)]
            public bool? OpenPublicNet { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>milvus_milvuspre_public_cn</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-123xxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1743679</para>
            /// </summary>
            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public long? RunningTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-123xxx</para>
            /// </summary>
            [NameInMap("SgId")]
            [Validation(Required=false)]
            public string SgId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.4.1-1.0-0.0.1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dataCoord:\n  segment:\n    maxSize: 1024</para>
            /// </summary>
            [NameInMap("UserConfig")]
            [Validation(Required=false)]
            public string UserConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.4</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-123xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-123xxx</para>
            /// </summary>
            [NameInMap("VswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Failed to find instance c-123xxx</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABCD-1234-5678-EFGH</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
