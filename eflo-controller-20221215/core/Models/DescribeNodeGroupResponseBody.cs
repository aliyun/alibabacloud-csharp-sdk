// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNodeGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-a</para>
        /// </summary>
        [NameInMap("Az")]
        [Validation(Required=false)]
        public string Az { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i111987311754895199538</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-basic-cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-07T17:19:42.980000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether file storage can be mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i190720111752146430748</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alinux3_x86_5.10.134-16.3_NV_RunC_D3_E3C7_570.133.20_V1.0_250428</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-key</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>Valid values:
        /// • password: The node group supports only password-based logon.
        /// • keypair: The node group supports only key pair-based logon.
        /// • both: The node group supports password-based and key pair-based logon.</para>
        /// <para>If this parameter is not returned, no logon method is configured for the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("LoginType")]
        [Validation(Required=false)]
        public string LoginType { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efg2.NH2cn</para>
        /// </summary>
        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        /// <summary>
        /// <para>The number of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public string NodeCount { get; set; }

        /// <summary>
        /// <para>The description of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjun alinux node group</para>
        /// </summary>
        [NameInMap("NodeGroupDescription")]
        [Validation(Required=false)]
        public string NodeGroupDescription { get; set; }

        /// <summary>
        /// <para>The ID of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i120982301752461697971</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The name of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ack</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>The name of the RAM role. You can call the ListRoles operation of the RAM API to query the RAM roles that you created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xianwen-test-ram-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83896080-59E3-5775-BDDC-8084691C3D96</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The system disk information.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribeNodeGroupResponseBodySystemDisk SystemDisk { get; set; }
        public class DescribeNodeGroupResponseBodySystemDisk : TeaModel {
            /// <summary>
            /// <para>The category of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Basic disk: 20–500.</para>
            /// </description></item>
            /// <item><description><para>ESSD:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: 1–2,048.</para>
            /// </description></item>
            /// <item><description><para>PL1: 20–2,048.</para>
            /// </description></item>
            /// <item><description><para>PL2: 461–2,048.</para>
            /// </description></item>
            /// <item><description><para>PL3: 1,261–2,048.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ESSD AutoPL disk: 1–2,048.</para>
            /// </description></item>
            /// <item><description><para>Other disk categories: 20–2,048.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: the larger value between 20 and the size of the image that is specified by <c>ImageId</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The time when the node group was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-20T11:18:11.164000</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The user data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash
        /// uptime
        /// echo &quot;aaaaaaa&quot; &gt;&gt; /tmp/tttest.sh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>Indicates whether the node group supports GPU virtualization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("VirtualGpuEnabled")]
        [Validation(Required=false)]
        public bool? VirtualGpuEnabled { get; set; }

    }

}
