// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ReimageNodesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i15dfa12e8f27c44f4a006c2c8bb</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow skipping failed nodes. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>The list of nodes. The node IDs must belong to created Lingjun nodes. You can obtain the node IDs by calling the ListClusterNodes or ListFreeNodes operation.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ReimageNodesRequestNodes> Nodes { get; set; }
        public class ReimageNodesRequestNodes : TeaModel {
            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>457db5ca-241d-11ed-9fd7-acde48001122</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The system image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-8vbf8rpv2nn14y7oybjy</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The logon password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Demo****123!</para>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-zvp2tgykr0b</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The system disk configuration.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public ReimageNodesRequestNodesSystemDisk SystemDisk { get; set; }
            public class ReimageNodesRequestNodesSystemDisk : TeaModel {
                /// <summary>
                /// <para>The disk category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Encrypts the system disk.</description></item>
                /// <item><description>false: Does not encrypt the system disk.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <remarks>
                /// <para>Notice: When you use a shared encrypted image to create a cloud disk from an encrypted snapshot, you must specify the request parameter Encrypted=true for the cloud disk to ensure that the created cloud disk is encrypted by using the key of the recipient account.</para>
                /// </remarks>
                /// <remarks>
                /// <para>System disk encryption during instance creation is not supported in Hong Kong (China) active zone D and Singapore active zone A.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The KMS key ID for the system disk.</para>
                /// <para>If the Encrypted Settings is true but KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
                /// <list type="bullet">
                /// <item><description>If the cloud disk is created from a non-shared encrypted snapshot, the encryption key used for the snapshot is used by default.</description></item>
                /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
                /// <item><description>If the cloud disk is created in a region where account-level default encryption for block storage is enabled, the specified account-level key is used by default.</description></item>
                /// <item><description>In other cases, the service key is used by default.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5b21a1c4-e2e8-43b2-a982-720fa9e6b9d7</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The performance level.</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The disk size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

        }

        /// <summary>
        /// <para>The custom executable shell script. The script must be Base64-encoded. The maximum size of the raw data is 16 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
