// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118191731740041623425</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroup")]
        [Validation(Required=false)]
        public CreateNodeGroupRequestNodeGroup NodeGroup { get; set; }
        public class CreateNodeGroupRequestNodeGroup : TeaModel {
            /// <summary>
            /// <para>The zone.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("Az")]
            [Validation(Required=false)]
            public string Az { get; set; }

            /// <summary>
            /// <para>Specifies whether file storage mounting is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FileSystemMountEnabled")]
            [Validation(Required=false)]
            public bool? FileSystemMountEnabled { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i191887641687336652616</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the key pair. You must specify at least one of LoginPassword and KeyPairName. If neither is specified, the API returns InvalidParameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-keypair</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The logon password. You must specify at least one of LoginPassword and KeyPairName. If neither is specified, the API returns InvalidParameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-LoginPassword</para>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mock-machine-type3</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>The description of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node group description</para>
            /// </summary>
            [NameInMap("NodeGroupDescription")]
            [Validation(Required=false)]
            public string NodeGroupDescription { get; set; }

            /// <summary>
            /// <para>The name of the node group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAI-LINGJUN</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>The name of the RAM role for the node. You can call the ListRoles operation of RAM to query the RAM roles that you have created. The trusted entity of the specified role must be Lingjun AI Computing Service. Note: You cannot clear an existing role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xianwen-test-ram-role</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The system cloud disk configuration of the node.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateNodeGroupRequestNodeGroupSystemDisk SystemDisk { get; set; }
            public class CreateNodeGroupRequestNodeGroupSystemDisk : TeaModel {
                /// <summary>
                /// <para>The cloud disk type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>clou_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt the system cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Encrypts the system cloud disk.</description></item>
                /// <item><description>false: Does not encrypt the system cloud disk.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <remarks>
                /// <para>Notice: When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must set the Encrypted request parameter to true for the cloud disk to ensure that the created cloud disk uses the key of the account that receives the shared image.</para>
                /// </remarks>
                /// <remarks>
                /// <para>System cloud disk encryption during instance creation is not supported in Hong Kong (China) Zone D and Singapore Zone A.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The KMS key ID corresponding to the system cloud disk.</para>
                /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
                /// <list type="bullet">
                /// <item><description>If the cloud disk is created from a non-shared encrypted snapshot, the encryption key used for the snapshot is used by default.</description></item>
                /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
                /// <item><description>If the cloud disk is created in a region where account-level default encryption for Block Storage is enabled, the specified account-level key is used by default.</description></item>
                /// <item><description>In other cases, the service key is used by default.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2ae0a815-a877-4bce-b5ec-4becb8ab4d89</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD when used as the system cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: Up to 10,000 random read/write IOPS per disk.</description></item>
                /// <item><description>PL1: Up to 50,000 random read/write IOPS per disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the system cloud disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

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

            /// <summary>
            /// <para>Specifies whether to enable vGPU splitting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VirtualGpuEnabled")]
            [Validation(Required=false)]
            public bool? VirtualGpuEnabled { get; set; }

        }

        /// <summary>
        /// <para>The node information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NodeUnitId&quot;:&quot;3c2999a8-2b95-4409-93c5-ad3985fc5c9f&quot;,&quot;ResourceGroupId&quot;:&quot;&quot;,&quot;MaxNodes&quot;:0,&quot;NodeUnitName&quot;:&quot;asi_cn-serverless-sale_e01-lingjun-psale&quot;}</para>
        /// </summary>
        [NameInMap("NodeUnit")]
        [Validation(Required=false)]
        public Dictionary<string, object> NodeUnit { get; set; }

    }

}
