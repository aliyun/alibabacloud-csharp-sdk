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
            /// <para>The key pair name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-keypair</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The logon password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-LoginPassword</para>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The machine type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mock-machine-type3</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>The node group description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>节点分组描述</para>
            /// </summary>
            [NameInMap("NodeGroupDescription")]
            [Validation(Required=false)]
            public string NodeGroupDescription { get; set; }

            /// <summary>
            /// <para>The node group name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAI-LINGJUN</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>The RAM role name of the node. You can call the RAM API ListRoles to query the RAM roles you have created. The trusted entity of the role must be set to Lingjun AI Computing Service.</para>
            /// <remarks>
            /// <para>Note: Clearing an existing role is not currently supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>xianwen-test-ram-role</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The system disk configuration of the node.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateNodeGroupRequestNodeGroupSystemDisk SystemDisk { get; set; }
            public class CreateNodeGroupRequestNodeGroupSystemDisk : TeaModel {
                /// <summary>
                /// <para>The cloud disk type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_essd: Enterprise SSD (ESSD) cloud disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>clou_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The performance level (PL) of the ESSD cloud disk used as the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: a maximum of 10,000 random read/write IOPS per cloud disk.</description></item>
                /// <item><description>PL1: a maximum of 50,000 random read/write IOPS per cloud disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The disk size. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>A custom executable shell script that must be Base64-encoded. The maximum size of the raw data is 16 KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>Specifies whether GPU virtualization splitting is enabled.</para>
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
        /// <para>{\&quot;NodeUnitId\&quot;:\&quot;3c2999a8-2b95-4409-93c5-ad3985fc5c9f\&quot;,\&quot;ResourceGroupId\&quot;:\&quot;\&quot;,\&quot;MaxNodes\&quot;:0,\&quot;NodeUnitName\&quot;:\&quot;asi_cn-serverless-sale_e01-lingjun-psale\&quot;}</para>
        /// </summary>
        [NameInMap("NodeUnit")]
        [Validation(Required=false)]
        public Dictionary<string, object> NodeUnit { get; set; }

    }

}
