// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118191731740041623425</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Node ID.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroup")]
        [Validation(Required=false)]
        public CreateNodeGroupRequestNodeGroup NodeGroup { get; set; }
        public class CreateNodeGroupRequestNodeGroup : TeaModel {
            /// <summary>
            /// <para>Availability Zone</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("Az")]
            [Validation(Required=false)]
            public string Az { get; set; }

            /// <summary>
            /// <para>Image ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i191887641687336652616</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>Machine type</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mock-machine-type3</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>Node group description</para>
            /// 
            /// <b>Example:</b>
            /// <para>describe for node group</para>
            /// </summary>
            [NameInMap("NodeGroupDescription")]
            [Validation(Required=false)]
            public string NodeGroupDescription { get; set; }

            /// <summary>
            /// <para>Node group name</para>
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
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>user data</para>
            /// 
            /// <b>Example:</b>
            /// <para>#!/bin/bash
            /// uptime
            /// echo &quot;aaaaaaa&quot; &gt;&gt; /tmp/ttttt20250110141010.sh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>Node information</para>
        /// </summary>
        [NameInMap("NodeUnit")]
        [Validation(Required=false)]
        public Dictionary<string, object> NodeUnit { get; set; }

    }

}
