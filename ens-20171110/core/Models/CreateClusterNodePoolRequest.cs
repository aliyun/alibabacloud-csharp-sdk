// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClusterNodePoolRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("KubernetesConfig")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestKubernetesConfig KubernetesConfig { get; set; }
        public class CreateClusterNodePoolRequestKubernetesConfig : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodepoolInfo")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestNodepoolInfo NodepoolInfo { get; set; }
        public class CreateClusterNodePoolRequestNodepoolInfo : TeaModel {
            /// <summary>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScalingGroup")]
        [Validation(Required=false)]
        public CreateClusterNodePoolRequestScalingGroup ScalingGroup { get; set; }
        public class CreateClusterNodePoolRequestScalingGroup : TeaModel {
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<CreateClusterNodePoolRequestScalingGroupDataDisks> DataDisks { get; set; }
            public class CreateClusterNodePoolRequestScalingGroupDataDisks : TeaModel {
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
            /// <para>3</para>
            /// </summary>
            [NameInMap("DesiredSize")]
            [Validation(Required=false)]
            public int? DesiredSize { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-6734fzvcwcv2o8jj201cpa7ox</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
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
            /// <para>some-test-password</para>
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

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

    }

}
