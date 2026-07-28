// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class GetInstanceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission verification failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;milvus:xxxx&quot; }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceDetailResponseBodyData Data { get; set; }
        public class GetInstanceDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ACL ID for public network access control.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-123xxx</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716863508000</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>milvus-test</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The bucket path.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss.console.aliyun.com/bucket/oss-cn-beijing/xxxx/object?spm=a2cug.25127996.0.0.577990370Ebsqt&path=milvus-c-123xxxx">https://oss.console.aliyun.com/bucket/oss-cn-beijing/xxxx/object?spm=a2cug.25127996.0.0.577990370Ebsqt&amp;path=milvus-c-123xxxx</a></para>
            /// </summary>
            [NameInMap("BucketPath")]
            [Validation(Required=false)]
            public string BucketPath { get; set; }

            /// <summary>
            /// <para>The instance details.</para>
            /// </summary>
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public GetInstanceDetailResponseBodyDataClusterInfo ClusterInfo { get; set; }
            public class GetInstanceDetailResponseBodyDataClusterInfo : TeaModel {
                /// <summary>
                /// <para>The Attu component port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("AttuPort")]
                [Validation(Required=false)]
                public int? AttuPort { get; set; }

                /// <summary>
                /// <para>The public network address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-123xxx-.milvus.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InternetUrl")]
                [Validation(Required=false)]
                public string InternetUrl { get; set; }

                /// <summary>
                /// <para>The internal network address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-123xxx-internal.milvus.aliyuncs.com</para>
                /// </summary>
                [NameInMap("IntranetUrl")]
                [Validation(Required=false)]
                public string IntranetUrl { get; set; }

                /// <summary>
                /// <para>The resource details.</para>
                /// </summary>
                [NameInMap("MilvusResourceInfoList")]
                [Validation(Required=false)]
                public List<GetInstanceDetailResponseBodyDataClusterInfoMilvusResourceInfoList> MilvusResourceInfoList { get; set; }
                public class GetInstanceDetailResponseBodyDataClusterInfoMilvusResourceInfoList : TeaModel {
                    /// <summary>
                    /// <para>The component type. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>standalone</para>
                    /// </summary>
                    [NameInMap("ComponentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// <para>The number of compute units (CUs).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("CuNum")]
                    [Validation(Required=false)]
                    public int? CuNum { get; set; }

                    /// <summary>
                    /// <para>The CU specifications. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("CuRatio")]
                    [Validation(Required=false)]
                    public int? CuRatio { get; set; }

                    /// <summary>
                    /// <para>The disk size.</para>
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

                    [NameInMap("PayType")]
                    [Validation(Required=false)]
                    public string PayType { get; set; }

                    /// <summary>
                    /// <para>The number of replicas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Replica")]
                    [Validation(Required=false)]
                    public int? Replica { get; set; }

                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("dataDiskEnabled")]
                    [Validation(Required=false)]
                    public bool? DataDiskEnabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("dataDiskSize")]
                    [Validation(Required=false)]
                    public int? DataDiskSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alicloud-disk-essd-pl1</para>
                    /// </summary>
                    [NameInMap("dataDiskStorageClass")]
                    [Validation(Required=false)]
                    public string DataDiskStorageClass { get; set; }

                    [NameInMap("podsList")]
                    [Validation(Required=false)]
                    public List<GetInstanceDetailResponseBodyDataClusterInfoMilvusResourceInfoListPodsList> PodsList { get; set; }
                    public class GetInstanceDetailResponseBodyDataClusterInfoMilvusResourceInfoListPodsList : TeaModel {
                        [NameInMap("podId")]
                        [Validation(Required=false)]
                        public string PodId { get; set; }

                        [NameInMap("podName")]
                        [Validation(Required=false)]
                        public string PodName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The OSS storage data size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>125.15 GB</para>
                /// </summary>
                [NameInMap("OssStorageSize")]
                [Validation(Required=false)]
                public string OssStorageSize { get; set; }

                /// <summary>
                /// <para>The timestamp of the OSS storage metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1718604000000</para>
                /// </summary>
                [NameInMap("OssStorageTimestamp")]
                [Validation(Required=false)]
                public long? OssStorageTimestamp { get; set; }

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
                /// <para>The total disk size.</para>
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
            /// <para>aliyun-test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>Indicates whether high availability is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableHa")]
            [Validation(Required=false)]
            public bool? EnableHa { get; set; }

            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721664000000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("HighAvailability")]
            [Validation(Required=false)]
            public GetInstanceDetailResponseBodyDataHighAvailability HighAvailability { get; set; }
            public class GetInstanceDetailResponseBodyDataHighAvailability : TeaModel {
                [NameInMap("CurrentActiveAZ")]
                [Validation(Required=false)]
                public string CurrentActiveAZ { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("PrimaryZoneId")]
                [Validation(Required=false)]
                public string PrimaryZoneId { get; set; }

                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

            }

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
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("KmsKeyId")]
            [Validation(Required=false)]
            public string KmsKeyId { get; set; }

            [NameInMap("MaintainablePeriod")]
            [Validation(Required=false)]
            public string MaintainablePeriod { get; set; }

            /// <summary>
            /// <para>The configuration information.</para>
            /// </summary>
            [NameInMap("MeasureConfig")]
            [Validation(Required=false)]
            public GetInstanceDetailResponseBodyDataMeasureConfig MeasureConfig { get; set; }
            public class GetInstanceDetailResponseBodyDataMeasureConfig : TeaModel {
                /// <summary>
                /// <para>The number of CUs for the Data node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("DataNodeCuNum")]
                [Validation(Required=false)]
                public int? DataNodeCuNum { get; set; }

                /// <summary>
                /// <para>The number of replicas for the Data node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DataNodeReplica")]
                [Validation(Required=false)]
                public int? DataNodeReplica { get; set; }

                /// <summary>
                /// <para>The number of CUs for the Index node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("IndexNodeCuNum")]
                [Validation(Required=false)]
                public int? IndexNodeCuNum { get; set; }

                /// <summary>
                /// <para>The number of replicas for the Index node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("IndexNodeReplica")]
                [Validation(Required=false)]
                public int? IndexNodeReplica { get; set; }

                /// <summary>
                /// <para>The number of CUs for the MixCoordinator node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MixCoodinatorNodeCuNum")]
                [Validation(Required=false)]
                public int? MixCoodinatorNodeCuNum { get; set; }

                /// <summary>
                /// <para>The number of replicas for the MixCoordinator node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MixCoodinatorNodeReplica")]
                [Validation(Required=false)]
                public int? MixCoodinatorNodeReplica { get; set; }

                /// <summary>
                /// <para>The number of CUs for the Proxy node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ProxyNodeCuNum")]
                [Validation(Required=false)]
                public int? ProxyNodeCuNum { get; set; }

                /// <summary>
                /// <para>The number of replicas for the Proxy node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ProxyNodeReplica")]
                [Validation(Required=false)]
                public int? ProxyNodeReplica { get; set; }

                /// <summary>
                /// <para>The number of CUs for the Query node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("QueryNodeCuNum")]
                [Validation(Required=false)]
                public int? QueryNodeCuNum { get; set; }

                /// <summary>
                /// <para>The number of replicas for the Query node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("QueryNodeReplica")]
                [Validation(Required=false)]
                public int? QueryNodeReplica { get; set; }

            }

            [NameInMap("MultiZoneMode")]
            [Validation(Required=false)]
            public string MultiZoneMode { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
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
            /// <para>The specification details. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The billing type. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public int? PayType { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>milvus_milvuspre_public_cn</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The region.</para>
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
            /// <para>The running time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743679</para>
            /// </summary>
            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public long? RunningTime { get; set; }

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
            /// <para>The tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetInstanceDetailResponseBodyDataTags> Tags { get; set; }
            public class GetInstanceDetailResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The software stack version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.4.1-1.0-0.0.1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The user-defined configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataCoord:\n  segment:\n    maxSize: 1024</para>
            /// </summary>
            [NameInMap("UserConfig")]
            [Validation(Required=false)]
            public string UserConfig { get; set; }

            [NameInMap("VSwitches")]
            [Validation(Required=false)]
            public List<GetInstanceDetailResponseBodyDataVSwitches> VSwitches { get; set; }
            public class GetInstanceDetailResponseBodyDataVSwitches : TeaModel {
                [NameInMap("VswId")]
                [Validation(Required=false)]
                public string VswId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The Milvus version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.4</para>
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
            /// <para>The zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("maintainablePeriodTimeZone")]
            [Validation(Required=false)]
            public string MaintainablePeriodTimeZone { get; set; }

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

    }

}
