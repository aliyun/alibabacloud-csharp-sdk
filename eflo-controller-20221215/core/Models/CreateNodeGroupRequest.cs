// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster to which the node group belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118191731740041623425</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The configurations of the node group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroup")]
        [Validation(Required=false)]
        public CreateNodeGroupRequestNodeGroup NodeGroup { get; set; }
        public class CreateNodeGroupRequestNodeGroup : TeaModel {
            /// <summary>
            /// <para>The availability zone of the node group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("Az")]
            [Validation(Required=false)]
            public string Az { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable file system mounting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FileSystemMountEnabled")]
            [Validation(Required=false)]
            public bool? FileSystemMountEnabled { get; set; }

            /// <summary>
            /// <para>The image ID for the nodes.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i191887641687336652616</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the key pair for SSH login.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-keypair</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The password to log in to the nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-LoginPassword</para>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The machine type for the nodes.</para>
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
            /// <para>The name of the RAM role to attach to the nodes. You can call the RAM API <c>ListRoles</c> operation to query the RAM roles that you have created. The trust entity of the specified role must be Intelligent Computing Lingjun.<br><b>Note:</b> You cannot detach an existing role by clearing this parameter.<br></para>
            /// 
            /// <b>Example:</b>
            /// <para>xianwen-test-ram-role</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The system disk configuration for the nodes.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateNodeGroupRequestNodeGroupSystemDisk SystemDisk { get; set; }
            public class CreateNodeGroupRequestNodeGroupSystemDisk : TeaModel {
                /// <summary>
                /// <para>The type of the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>cloud_essd</c>: ESSD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>clou_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>PL0</c>: A single disk delivers up to 10,000 random read/write IOPS.</para>
                /// </description></item>
                /// <item><description><para><c>PL1</c>: A single disk delivers up to 50,000 random read/write IOPS.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the system disk, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The user data passed to the nodes at launch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#!/bin/bash
            /// uptime
            /// echo &quot;aaaaaaa&quot; &gt;&gt; /tmp/ttttt20250110141010.sh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable GPU virtualization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VirtualGpuEnabled")]
            [Validation(Required=false)]
            public bool? VirtualGpuEnabled { get; set; }

        }

        /// <summary>
        /// <para>The configuration of the node unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;NodeUnitId\&quot;:\&quot;3c2999a8-2b95-4409-93c5-ad3985fc5c9f\&quot;,\&quot;ResourceGroupId\&quot;:\&quot;\&quot;,\&quot;MaxNodes\&quot;:0,\&quot;NodeUnitName\&quot;:\&quot;asi_cn-serverless-sale_e01-lingjun-psale\&quot;}</para>
        /// </summary>
        [NameInMap("NodeUnit")]
        [Validation(Required=false)]
        public Dictionary<string, object> NodeUnit { get; set; }

    }

}
