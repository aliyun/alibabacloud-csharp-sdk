// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClusterNodePoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The node pool configurations.</para>
        /// </summary>
        [NameInMap("Nodepool")]
        [Validation(Required=false)]
        public CreateClusterNodePoolResponseBodyNodepool Nodepool { get; set; }
        public class CreateClusterNodePoolResponseBodyNodepool : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eck-d2666c5f</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The Kubernetes-related configurations.</para>
            /// </summary>
            [NameInMap("KubernetesConfig")]
            [Validation(Required=false)]
            public CreateClusterNodePoolResponseBodyNodepoolKubernetesConfig KubernetesConfig { get; set; }
            public class CreateClusterNodePoolResponseBodyNodepoolKubernetesConfig : TeaModel {
                /// <summary>
                /// <para>The script to be executed after the instance is created and before it is added to the cluster. The content must be Base64-encoded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZWNobyBvawo=</para>
                /// </summary>
                [NameInMap("PreUserData")]
                [Validation(Required=false)]
                public string PreUserData { get; set; }

                /// <summary>
                /// <para>The script to be executed after the instance is created and added to the cluster. The content must be Base64-encoded.</para>
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
            public CreateClusterNodePoolResponseBodyNodepoolNodepoolInfo NodepoolInfo { get; set; }
            public class CreateClusterNodePoolResponseBodyNodepoolNodepoolInfo : TeaModel {
                /// <summary>
                /// <para>The ENS region ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-guiyang-14</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The cluster name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The node pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>np1176939548ac49e59febe82dcbf1ad56</para>
                /// </summary>
                [NameInMap("NodepoolId")]
                [Validation(Required=false)]
                public string NodepoolId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group to which the newly created scaling group belongs. You can assign the newly created scaling group to a specified resource group. If you do not specify this parameter, the scaling group is assigned to the default resource group.</para>
            /// </summary>
            [NameInMap("ScalingGroup")]
            [Validation(Required=false)]
            public CreateClusterNodePoolResponseBodyNodepoolScalingGroup ScalingGroup { get; set; }
            public class CreateClusterNodePoolResponseBodyNodepoolScalingGroup : TeaModel {
                /// <summary>
                /// <para>The data cloud disk information of the nodes.</para>
                /// </summary>
                [NameInMap("DataDisks")]
                [Validation(Required=false)]
                public List<CreateClusterNodePoolResponseBodyNodepoolScalingGroupDataDisks> DataDisks { get; set; }
                public class CreateClusterNodePoolResponseBodyNodepoolScalingGroupDataDisks : TeaModel {
                    /// <summary>
                    /// <para>The disk category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_efficiency</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The size of the data cloud disk. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                }

                /// <summary>
                /// <para>The image ID of the control plane virtual machine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-67bdk1kpu1ylmt7k33h5dbiov</para>
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
                /// <para>The list of instance types for the nodes in the node pool.</para>
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
                /// <para>The logon password of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The system cloud disk category of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// <para>The size of the system cloud disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The IDs of the vSwitches where the cluster nodes reside.</para>
                /// </summary>
                [NameInMap("VswitchIds")]
                [Validation(Required=false)]
                public List<string> VswitchIds { get; set; }

            }

            /// <summary>
            /// <para>The status information of the node pool.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public CreateClusterNodePoolResponseBodyNodepoolStatus Status { get; set; }
            public class CreateClusterNodePoolResponseBodyNodepoolStatus : TeaModel {
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
                /// <para>The nodes that failed to be created in the node pool.</para>
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
                /// <para>The number of instances that are in use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ServingNodes")]
                [Validation(Required=false)]
                public int? ServingNodes { get; set; }

                /// <summary>
                /// <para>The state of the node pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>active: The desired state is reached.</description></item>
                /// <item><description>scaling: The node pool is scaling out.</description></item>
                /// <item><description>removing_nodes: The node pool is scaling in.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The total number of instances, including instances that are being created, in use, and being deleted.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
