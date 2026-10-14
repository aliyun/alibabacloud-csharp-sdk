// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterNodePoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node pools.</para>
        /// </summary>
        [NameInMap("NodePools")]
        [Validation(Required=false)]
        public List<DescribeClusterNodePoolsResponseBodyNodePools> NodePools { get; set; }
        public class DescribeClusterNodePoolsResponseBodyNodePools : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eck-xxxxxxxx</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01T00:00:00+08:00</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The Kubernetes-related configurations.</para>
            /// </summary>
            [NameInMap("KubernetesConfig")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodePoolsKubernetesConfig KubernetesConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodePoolsKubernetesConfig : TeaModel {
                /// <summary>
                /// <para>The script to execute after the instance is created and before it is added to the cluster. The content must be Base64-encoded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZWNobyBvawo=</para>
                /// </summary>
                [NameInMap("PreUserData")]
                [Validation(Required=false)]
                public string PreUserData { get; set; }

                /// <summary>
                /// <para>The script to execute after the instance is created and added to the cluster. The content must be Base64-encoded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZWNobyBvawo=</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>The node pool information.</para>
            /// </summary>
            [NameInMap("NodepoolInfo")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodePoolsNodepoolInfo NodepoolInfo { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodePoolsNodepoolInfo : TeaModel {
                /// <summary>
                /// <para>The ENS edge zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-fuzhou-23</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The name of the node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eck-node-pool-1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>np68mi5y1dd748ky37ojo2kqdrz</para>
                /// </summary>
                [NameInMap("NodepoolId")]
                [Validation(Required=false)]
                public string NodepoolId { get; set; }

            }

            /// <summary>
            /// <para>The scaling group.</para>
            /// </summary>
            [NameInMap("ScalingGroup")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodePoolsScalingGroup ScalingGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodePoolsScalingGroup : TeaModel {
                /// <summary>
                /// <para>The list of data cloud disks. The parameter limits are the same as those of the system cloud disk.</para>
                /// </summary>
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public List<DescribeClusterNodePoolsResponseBodyNodePoolsScalingGroupDataDisks> DataDisks { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodePoolsScalingGroupDataDisks : TeaModel {
                    /// <summary>
                    /// <para>The cloud disk category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_efficiency</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The cloud disk size. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-673f5z4h69ibwtallg6zmcaxr</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The billing method of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The list of instance types.</para>
                /// </summary>
                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <para>The name of the key pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-pair-name</para>
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                /// <summary>
                /// <para>The password of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The system cloud disk category of the node. Valid values: local_ssd, cloud_ssd, cloud_efficiency, and local_hdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// <para>The size of the system cloud disk for the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// </summary>
                [NameInMap("VswitchIds")]
                [Validation(Required=false)]
                public List<string> VswitchIds { get; set; }

            }

            /// <summary>
            /// <para>The status of the node pool.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodePoolsStatus Status { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodePoolsStatus : TeaModel {
                /// <summary>
                /// <para>The expected number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DesiredNodes")]
                [Validation(Required=false)]
                public int? DesiredNodes { get; set; }

                /// <summary>
                /// <para>The number of nodes that failed to be created in the node pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedNodes")]
                [Validation(Required=false)]
                public int? FailedNodes { get; set; }

                /// <summary>
                /// <para>The number of instances that are being created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InitialNodes")]
                [Validation(Required=false)]
                public int? InitialNodes { get; set; }

                /// <summary>
                /// <para>The number of instances that are being deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemovingNodes")]
                [Validation(Required=false)]
                public int? RemovingNodes { get; set; }

                /// <summary>
                /// <para>The number of instances in use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ServingNodes")]
                [Validation(Required=false)]
                public int? ServingNodes { get; set; }

                /// <summary>
                /// <para>The state of the node pool.</para>
                /// <list type="bullet">
                /// <item><description>active: The desired state is reached.</description></item>
                /// <item><description>scaling: Scaling out.</description></item>
                /// <item><description>removing_nodes: Scaling in.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The total number of instances, including those that are being created, in use, and being deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalNodes")]
                [Validation(Required=false)]
                public int? TotalNodes { get; set; }

            }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolsResponseBodyPage Page { get; set; }
        public class DescribeClusterNodePoolsResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page specified in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3B261DD-3858-4D3C-877D-303ADF374600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
