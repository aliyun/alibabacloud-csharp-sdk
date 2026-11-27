// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNodeGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The zone.</para>
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
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-basic-cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The creation time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-07T17:19:42.980000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

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
        /// <para>The ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i190720111752146430748</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image name.</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>password: The current group supports only password logon. </description></item>
        /// <item><description>keypair: The current group supports only key pair logon. </description></item>
        /// <item><description>both: The current group supports both password and key pair logon.</description></item>
        /// </list>
        /// <para>If this parameter is empty, no logon method is configured for the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("LoginType")]
        [Validation(Required=false)]
        public string LoginType { get; set; }

        /// <summary>
        /// <para>The machine type.</para>
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
        /// <para>The name of the RAM role for the node. You can call the ListRoles operation of RAM to query the RAM roles that you have created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xianwen-test-ram-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>83896080-59E3-5775-BDDC-8084691C3D96</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The system cloud disk information.</para>
        /// </summary>
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribeNodeGroupResponseBodySystemDisk SystemDisk { get; set; }
        public class DescribeNodeGroupResponseBodySystemDisk : TeaModel {
            /// <summary>
            /// <para>The category of the cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether the system cloud disk is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The system cloud disk is encrypted.</description></item>
            /// <item><description>false: The system cloud disk is not encrypted.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Notice: When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must set the Encrypted request parameter to true for the cloud disk. This ensures that the created cloud disk uses the key of the account that the image is shared with.</notice></para>
            /// </remarks>
            /// <remarks>
            /// <para>You cannot encrypt the system cloud disk when you create an instance in Hong Kong (China) Zone D or Singapore Zone A.</para>
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
            /// <para>If the Encrypted parameter is set to true but KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
            /// <list type="bullet">
            /// <item><description>If the cloud disk is created from a non-shared encrypted snapshot, the encryption key used for the snapshot is used by default.</description></item>
            /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
            /// <item><description>If the cloud disk is created in a region where account-level default encryption for Block Storage is enabled, the specified account-level key is used by default.</description></item>
            /// <item><description>In other cases, the service key is used by default.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2d504554-333a-47c8-8d98-de36a23a1a4f</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD used as the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Basic cloud disk: 20 to 500.</description></item>
            /// <item><description>ESSD:<list type="bullet">
            /// <item><description>PL0: 1 to 2048.</description></item>
            /// <item><description>PL1: 20 to 2048.</description></item>
            /// <item><description>PL2: 461 to 2048.</description></item>
            /// <item><description>PL3: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>ESSD AutoPL cloud disk: 1 to 2048.</description></item>
            /// <item><description>Other cloud disk types: 20 to 2048.</description></item>
            /// </list>
            /// <para>Default value: max{20, the size of the image specified by the ImageId parameter}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The update time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-20T11:18:11.164000</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The user-defined script.</para>
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
        /// <para>Specifies whether GPU virtualization and partitioning are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("VirtualGpuEnabled")]
        [Validation(Required=false)]
        public bool? VirtualGpuEnabled { get; set; }

    }

}
