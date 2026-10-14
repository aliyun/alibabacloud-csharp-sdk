// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster-related configurations.</para>
        /// </summary>
        [NameInMap("KubernetesConfig")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>The script to be executed after the machine is created and before it is added to the cluster. The content must be Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBvawo=</para>
            /// </summary>
            [NameInMap("PreUserData")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The script to be executed after the machine is created and added to the cluster. The content must be Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBvawo=</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The node pool configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodepoolInfo")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>The name of the node pool.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The scaling group configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScalingGroup")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>The size of the data cloud disk. Unit: GB.</para>
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupDataDisks> DataDisks { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupDataDisks : TeaModel {
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
                /// <para>The size of the data cloud disk. Unit: GB. Minimum value: 20. The value must be a multiple of 10.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The expected number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DesiredSize")]
            [Validation(Required=false)]
            public int? DesiredSize { get; set; }

            /// <summary>
            /// <para>The image ID of the instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-6734fzvcwcv2o8jj201cpa7ox</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The billing method of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The list of instance types for the nodes in the node pool.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The key pair of the instance. This parameter and Password are mutually exclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-pair-name</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The password used when creating instances in the node pool. This parameter and KeyPairName are mutually exclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>some-test-password</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The category of the system cloud disk. Valid values: local_ssd, local_hdd, cloud_efficiency, and cloud_ssd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GB. Minimum value: 20. The value must be a multiple of 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The vSwitches used by the instances.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

    }

}
