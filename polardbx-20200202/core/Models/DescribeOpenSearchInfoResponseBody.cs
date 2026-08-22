// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeOpenSearchInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeOpenSearchInfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeOpenSearchInfoResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The identity used for authentication in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The authentication principal type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of the permission denial.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The returned result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOpenSearchInfoResponseBodyData Data { get; set; }
        public class DescribeOpenSearchInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instance information.</para>
            /// </summary>
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public DescribeOpenSearchInfoResponseBodyDataInstance Instance { get; set; }
            public class DescribeOpenSearchInfoResponseBodyDataInstance : TeaModel {
                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
                /// <item><description><b>PREPAY</b>: subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The OpenSearch-compatible version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("CompatibleVersion")]
                [Validation(Required=false)]
                public string CompatibleVersion { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-02-17T02:00:20Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The deployment mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>multiple: multi-zone deployment.</description></item>
                /// <item><description>single: single-zone deployment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// <para>The DPI engine version. Default value: 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>anchashi</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-27T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-spsil01pww4hfz-mem</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-bjr76v5uw7z4f5fs-cdc</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The network type of the connection string. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b>: public endpoint.</description></item>
                /// <item><description><b>Private</b>: private endpoint.</description></item>
                /// <item><description><b>Inner</b>: private endpoint (classic network).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-1</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the last task was updated (in timestamp format).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-09-02T16:01:51Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) in which the access endpoint resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2ze99u5upo8zxyf5dlfl5</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID. This parameter is required when you create a DRDS instance of the VPC network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-2zes4ojp6ygziyvq3vhd2</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The specifications.</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeOpenSearchInfoResponseBodyDataSpec Spec { get; set; }
            public class DescribeOpenSearchInfoResponseBodyDataSpec : TeaModel {
                /// <summary>
                /// <para>The number of coordinator nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CoordinatorNodeCount")]
                [Validation(Required=false)]
                public int? CoordinatorNodeCount { get; set; }

                /// <summary>
                /// <para>The number of CPU cores of a single coordinator node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CoordinatorNodeCpu")]
                [Validation(Required=false)]
                public int? CoordinatorNodeCpu { get; set; }

                /// <summary>
                /// <para>Indicates whether coordinator nodes are enabled.</para>
                /// </summary>
                [NameInMap("CoordinatorNodeEnabled")]
                [Validation(Required=false)]
                public bool? CoordinatorNodeEnabled { get; set; }

                /// <summary>
                /// <para>The memory size of a single coordinator node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("CoordinatorNodeMemoryGB")]
                [Validation(Required=false)]
                public int? CoordinatorNodeMemoryGB { get; set; }

                /// <summary>
                /// <para>The number of data nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DataNodeCount")]
                [Validation(Required=false)]
                public int? DataNodeCount { get; set; }

                /// <summary>
                /// <para>The number of CPU cores of a single data node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DataNodeCpu")]
                [Validation(Required=false)]
                public int? DataNodeCpu { get; set; }

                /// <summary>
                /// <para>The memory size of a single data node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("DataNodeMemoryGB")]
                [Validation(Required=false)]
                public int? DataNodeMemoryGB { get; set; }

                /// <summary>
                /// <para>The master node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The master node is a single node.</description></item>
                /// <item><description><b>2</b>: The master node is in Cluster Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MasterNodeCount")]
                [Validation(Required=false)]
                public int? MasterNodeCount { get; set; }

                /// <summary>
                /// <para>The number of CPU cores of a single dedicated master node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MasterNodeCpu")]
                [Validation(Required=false)]
                public int? MasterNodeCpu { get; set; }

                /// <summary>
                /// <para>Indicates whether dedicated master nodes are enabled.</para>
                /// </summary>
                [NameInMap("MasterNodeEnabled")]
                [Validation(Required=false)]
                public bool? MasterNodeEnabled { get; set; }

                /// <summary>
                /// <para>The memory size of a single dedicated master node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MasterNodeMemoryGB")]
                [Validation(Required=false)]
                public int? MasterNodeMemoryGB { get; set; }

                /// <summary>
                /// <para>The number of replica nodes in the primary zone.</para>
                /// <remarks>
                /// <para>The <b>ReplicaCount</b> and <b>SlaveReplicaCount</b> parameters apply only to cloud-native instances. If the instance uses a cluster architecture, these parameters indicate the number of replica nodes of a <b>single shard</b> in the primary and secondary zones.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReplicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                /// <summary>
                /// <para>The storage size of a single data node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("StorageSizeGB")]
                [Validation(Required=false)]
                public int? StorageSizeGB { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_auto</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>173CA69A-3513-591D-8A09-C1EA37CBE2D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
