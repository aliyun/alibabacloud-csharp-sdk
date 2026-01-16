// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterNodePoolsResponseBody : TeaModel {
        [NameInMap("NodePools")]
        [Validation(Required=false)]
        public List<DescribeClusterNodePoolsResponseBodyNodePools> NodePools { get; set; }
        public class DescribeClusterNodePoolsResponseBodyNodePools : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>eck-xxxxxxxx</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("KubernetesConfig")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodePoolsKubernetesConfig KubernetesConfig { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodePoolsKubernetesConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ZWNobyBvawo=</para>
                /// </summary>
                [NameInMap("PreUserData")]
                [Validation(Required=false)]
                public string PreUserData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ZWNobyBvawo=</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            [NameInMap("NodepoolInfo")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodePoolsNodepoolInfo NodepoolInfo { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodePoolsNodepoolInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-fuzhou-23</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eck-node-pool-1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>np68mi5y1dd748ky37ojo2kqdrz</para>
                /// </summary>
                [NameInMap("NodepoolId")]
                [Validation(Required=false)]
                public string NodepoolId { get; set; }

            }

            [NameInMap("ScalingGroup")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodePoolsScalingGroup ScalingGroup { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodePoolsScalingGroup : TeaModel {
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public List<DescribeClusterNodePoolsResponseBodyNodePoolsScalingGroupDataDisks> DataDisks { get; set; }
                public class DescribeClusterNodePoolsResponseBodyNodePoolsScalingGroupDataDisks : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cloud_efficiency</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>m-673f5z4h69ibwtallg6zmcaxr</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public List<string> InstanceTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>key-pair-name</para>
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                [NameInMap("VswitchIds")]
                [Validation(Required=false)]
                public List<string> VswitchIds { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeClusterNodePoolsResponseBodyNodePoolsStatus Status { get; set; }
            public class DescribeClusterNodePoolsResponseBodyNodePoolsStatus : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DesiredNodes")]
                [Validation(Required=false)]
                public int? DesiredNodes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InitialNodes")]
                [Validation(Required=false)]
                public int? InitialNodes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemovingNodes")]
                [Validation(Required=false)]
                public int? RemovingNodes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ServingNodes")]
                [Validation(Required=false)]
                public int? ServingNodes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TotalNodes")]
                [Validation(Required=false)]
                public int? TotalNodes { get; set; }

            }

        }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeClusterNodePoolsResponseBodyPage Page { get; set; }
        public class DescribeClusterNodePoolsResponseBodyPage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F3B261DD-3858-4D3C-877D-303ADF374600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
