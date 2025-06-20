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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroup")]
        [Validation(Required=false)]
        public CreateNodeGroupRequestNodeGroup NodeGroup { get; set; }
        public class CreateNodeGroupRequestNodeGroup : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("Az")]
            [Validation(Required=false)]
            public string Az { get; set; }

            /// <summary>
            /// <para>Indicates whether file storage mounting is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("FileSystemMountEnabled")]
            [Validation(Required=false)]
            public bool? FileSystemMountEnabled { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i191887641687336652616</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-keypair</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

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
            /// <b>Example:</b>
            /// <para>describe for node group</para>
            /// </summary>
            [NameInMap("NodeGroupDescription")]
            [Validation(Required=false)]
            public string NodeGroupDescription { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAI-LINGJUN</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateNodeGroupRequestNodeGroupSystemDisk SystemDisk { get; set; }
            public class CreateNodeGroupRequestNodeGroupSystemDisk : TeaModel {
                /// <summary>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// <item><description></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL!</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>250</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>#!/bin/bash
            /// uptime
            /// echo &quot;aaaaaaa&quot; &gt;&gt; /tmp/ttttt20250110141010.sh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("NodeUnit")]
        [Validation(Required=false)]
        public Dictionary<string, object> NodeUnit { get; set; }

    }

}
