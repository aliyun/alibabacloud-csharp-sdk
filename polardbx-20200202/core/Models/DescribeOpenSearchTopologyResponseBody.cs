// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeOpenSearchTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeOpenSearchTopologyResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeOpenSearchTopologyResponseBodyAccessDeniedDetail : TeaModel {
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
            /// <para>The display name of the authentication principal.</para>
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
            /// <para>NoPermissionType</para>
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
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOpenSearchTopologyResponseBodyData Data { get; set; }
        public class DescribeOpenSearchTopologyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The node IDs.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeOpenSearchTopologyResponseBodyDataNodes> Nodes { get; set; }
            public class DescribeOpenSearchTopologyResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t1222576965886205</para>
                /// </summary>
                [NameInMap("AvailabilityZone")]
                [Validation(Required=false)]
                public string AvailabilityZone { get; set; }

                /// <summary>
                /// <para>The total number of CPU cores in the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.25</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The Origin Domain Name that you configured in the DCDN console, including IPv4 addresses, IPv6 addresses, common domain names, and OSS domain names.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://secnet-defense-vastip.oss-cn-hangzhou.aliyuncs.com">https://secnet-defense-vastip.oss-cn-hangzhou.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>Indicates whether the current node is the primary node.</para>
                /// </summary>
                [NameInMap("IsLeader")]
                [Validation(Required=false)]
                public bool? IsLeader { get; set; }

                /// <summary>
                /// <para>The memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-c-jf0pivh2dt</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The role of a node in the three-node RDS cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>leader</b>: primary node</description></item>
                /// <item><description><b>follower</b>: secondary node</description></item>
                /// <item><description><b>logger</b>: logger node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>polarx_cn</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The node status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Running</description></item>
                /// <item><description><b>1</b>: Creating</description></item>
                /// <item><description><b>2</b>: Abnormal</description></item>
                /// <item><description><b>3</b>: Expired</description></item>
                /// <item><description><b>4</b>: Releasing</description></item>
                /// <item><description><b>5</b>: Released</description></item>
                /// <item><description><b>6</b>: Locked</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The configuration of the automatic storage scaling feature for the instance.</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public DescribeOpenSearchTopologyResponseBodyDataStorage Storage { get; set; }
            public class DescribeOpenSearchTopologyResponseBodyDataStorage : TeaModel {
                /// <summary>
                /// <para>The number of secondary nodes in the primary zone.</para>
                /// <remarks>
                /// <para>The <b>ReplicaCount</b> and <b>SlaveReplicaCount</b> parameters apply only to cloud-native instances. If the instance uses the cluster architecture, these parameters indicate the number of secondary nodes of a <b>single shard</b> in the primary and secondary zones.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReplicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                /// <summary>
                /// <para>The total storage capacity of the node. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("StorageTotalGB")]
                [Validation(Required=false)]
                public int? StorageTotalGB { get; set; }

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
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
