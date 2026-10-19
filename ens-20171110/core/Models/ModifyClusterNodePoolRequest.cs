// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>Only ECK cluster IDs with the eck- prefix are supported. You can obtain the ID by calling the DescribeClustersV1 operation. Serverless cluster IDs returned by the DescribeCluster operation are not supported. The cluster must be in the running state. After creation, it usually takes 10 to 20 minutes to complete initialization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The Kubernetes configuration.</para>
        /// </summary>
        [NameInMap("KubernetesConfig")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class ModifyClusterNodePoolRequestKubernetesConfig : TeaModel {
            /// <summary>
            /// <para>The script to be executed after the instance is created and before it joins the cluster. The content must be Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBvawo=</para>
            /// </summary>
            [NameInMap("PreUserData")]
            [Validation(Required=false)]
            public string PreUserData { get; set; }

            /// <summary>
            /// <para>The script to be executed after the instance is created and after it joins the cluster. The content must be Base64-encoded.</para>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodepoolInfo")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class ModifyClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
            /// <para>The name of the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the node pool.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np68mi5y1dd748ky37ojo2kqdrz</para>
            /// </summary>
            [NameInMap("NodepoolId")]
            [Validation(Required=false)]
            public string NodepoolId { get; set; }

        }

        /// <summary>
        /// <para>The scaling group configuration.</para>
        /// </summary>
        [NameInMap("ScalingGroup")]
        [Validation(Required=false)]
        public ModifyClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class ModifyClusterNodePoolRequestScalingGroup : TeaModel {
            /// <summary>
            /// <para>The data cloud disk information.</para>
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<ModifyClusterNodePoolRequestScalingGroupDataDisks> DataDisks { get; set; }
            public class ModifyClusterNodePoolRequestScalingGroupDataDisks : TeaModel {
                /// <summary>
                /// <para>The category of the data cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The size of the data cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-68bysm5a8gkm7oik7ngacf0in</para>
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
            /// <para>The instance types.</para>
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The name of the instance key pair. This parameter and Password are mutually exclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tf-testAcc</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The instance password. This parameter and key_pair_name are mutually exclusive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@AN5Ejx1YyzzK</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The category of the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The vSwitches used by the instances.</para>
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

    }

}
