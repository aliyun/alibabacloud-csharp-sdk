// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class UpdateNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether file storage mounting is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the default image for the node group. If you do not specify this parameter, the image remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i1232142432432</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The logon password for the machines in the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Password</para>
        /// </summary>
        [NameInMap("LoginPassword")]
        [Validation(Required=false)]
        public string LoginPassword { get; set; }

        /// <summary>
        /// <para>The name of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-update</para>
        /// </summary>
        [NameInMap("NewNodeGroupName")]
        [Validation(Required=false)]
        public string NewNodeGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i120021051733814190732</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role for the node. You can call the ListRoles operation of Resource Access Management (RAM) to query the RAM roles that you have created. The trusted entity of the specified role must be Lingjun AI Computing Service.
        /// <warning>Submitting an empty string &quot;&quot; clears the RAM role of the node group.</warning></para>
        /// 
        /// <b>Example:</b>
        /// <para>xianwen-test-ram-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The configuration of the system cloud disk.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public UpdateNodeGroupRequestSystemDisk SystemDisk { get; set; }
        public class UpdateNodeGroupRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The type of the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether the system cloud disk is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Encrypted.</description></item>
            /// <item><description>false: Not encrypted.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must set the Encrypted request parameter to true for the cloud disk to ensure that the created cloud disk uses the recipient&quot;s own key.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Encrypting the system cloud disk during instance creation is not supported in Hong Kong (China) Zone D or Singapore Zone A.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>The KMS key ID for the system cloud disk.</para>
            /// <para>If the Encrypted Settings is true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
            /// <list type="bullet">
            /// <item><description>If the cloud disk is created from an unshared encrypted snapshot, the encryption key used for the snapshot is used by default.</description></item>
            /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
            /// <item><description>If the cloud disk is created in a region where account-level default encryption for Elastic Block Storage (EBS) is enabled, the specified account-level key is used by default.</description></item>
            /// <item><description>In other cases, the service key is used by default.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>de1a73c4-9590-45da-8859-d39b5ec4751e</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

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
