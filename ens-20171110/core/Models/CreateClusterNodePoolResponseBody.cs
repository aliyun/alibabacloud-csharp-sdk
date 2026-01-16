// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClusterNodePoolResponseBody : TeaModel {
        [NameInMap("Nodepool")]
        [Validation(Required=false)]
        public CreateClusterNodePoolResponseBodyNodepool Nodepool { get; set; }
        public class CreateClusterNodePoolResponseBodyNodepool : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>eck-d2666c5f</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("KubernetesConfig")]
            [Validation(Required=false)]
            public CreateClusterNodePoolResponseBodyNodepoolKubernetesConfig KubernetesConfig { get; set; }
            public class CreateClusterNodePoolResponseBodyNodepoolKubernetesConfig : TeaModel {
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
            public CreateClusterNodePoolResponseBodyNodepoolNodepoolInfo NodepoolInfo { get; set; }
            public class CreateClusterNodePoolResponseBodyNodepoolNodepoolInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-guiyang-14</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>np1176939548ac49e59febe82dcbf1ad56</para>
                /// </summary>
                [NameInMap("NodepoolId")]
                [Validation(Required=false)]
                public string NodepoolId { get; set; }

            }

            [NameInMap("ScalingGroup")]
            [Validation(Required=false)]
            public CreateClusterNodePoolResponseBodyNodepoolScalingGroup ScalingGroup { get; set; }
            public class CreateClusterNodePoolResponseBodyNodepoolScalingGroup : TeaModel {
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public List<CreateClusterNodePoolResponseBodyNodepoolScalingGroupDataDisks> DataDisks { get; set; }
                public class CreateClusterNodePoolResponseBodyNodepoolScalingGroupDataDisks : TeaModel {
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
                /// <para>m-67bdk1kpu1ylmt7k33h5dbiov</para>
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
            public CreateClusterNodePoolResponseBodyNodepoolStatus Status { get; set; }
            public class CreateClusterNodePoolResponseBodyNodepoolStatus : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
