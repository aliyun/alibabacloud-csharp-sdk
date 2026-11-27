// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeHyperNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i119982311660892626523</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The creation time in ISO 8601 format. The Z in the example indicates UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-30T02:00:00.852Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The expiration time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2125-06-24T16:52:44.318000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether file system mounting is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        /// <summary>
        /// <para>The hostname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alywlcb-lingjun-gpu-0025</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The cluster number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1</para>
        /// </summary>
        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <para>The ID of the supernode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("HyperNodeId")]
        [Validation(Required=false)]
        public string HyperNodeId { get; set; }

        /// <summary>
        /// <para>The machine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efg1.nvga1</para>
        /// </summary>
        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        /// <summary>
        /// <para>The ID of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-ec3c96ff0aa4c60d</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The name of the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lisan-nodegroup</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeHyperNodeResponseBodyNodes> Nodes { get; set; }
        public class DescribeHyperNodeResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The cloud disk information.</para>
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeHyperNodeResponseBodyNodesDisks> Disks { get; set; }
            public class DescribeHyperNodeResponseBodyNodesDisks : TeaModel {
                /// <summary>
                /// <para>The data packet classification. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DOWNLINK_PACKET</b>: downlink packets</description></item>
                /// <item><description><b>UPLINK_PACKET</b>: uplink packets</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DOWNLINK_PACKET</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The ID of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp1564bcc2306uui4zpk</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>Indicates whether the system cloud disk is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The disk is encrypted.</description></item>
                /// <item><description>false: The disk is not encrypted.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <remarks>
                /// <para>Notice: When you create a cloud disk from an encrypted snapshot by using a shared encrypted image, you must specify the request parameter Encrypted=true for the cloud disk to ensure that the created cloud disk is encrypted by using the recipient&quot;s key.</para>
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
                /// <para>If the Encrypted parameter is set to true and the KMSKeyId parameter is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
                /// <list type="bullet">
                /// <item><description>If the cloud disk is created from an unshared encrypted snapshot, the encryption key used for the snapshot is used by default.</description></item>
                /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
                /// <item><description>If the cloud disk is created in a region where account-level default encryption for Block Storage is enabled, the specified account-level key is used by default.</description></item>
                /// <item><description>In other cases, the service key is used by default.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>67d1dc19-663a-447e-9f0c-7bee2d30c8aa</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD when it is used as the system cloud disk. Valid values:</para>
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
                /// <para>The size of the cloud disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The type of the cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: system cloud disk</description></item>
                /// <item><description>data: data cloud disk</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i190297201669099844192</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alinux3_x86_gu8xf_P_Host_D3_C7E3_550.127_Legacy_N_241230</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The network information.</para>
            /// </summary>
            [NameInMap("Networks")]
            [Validation(Required=false)]
            public DescribeHyperNodeResponseBodyNodesNetworks Networks { get; set; }
            public class DescribeHyperNodeResponseBodyNodesNetworks : TeaModel {
                /// <summary>
                /// <para>The name of the network interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond0</para>
                /// </summary>
                [NameInMap("BondName")]
                [Validation(Required=false)]
                public string BondName { get; set; }

                /// <summary>
                /// <para>The IP address of the machine in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.22.2</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-zvp2tgykr0b</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The status of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Using</para>
            /// </summary>
            [NameInMap("OperatingState")]
            [Validation(Required=false)]
            public string OperatingState { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InProgress</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            [Obsolete]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user-defined script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#!/bin/bash
            /// uptime
            /// echo &quot;aaaaaaa&quot; &gt;&gt; /tmp/ttttttest.sh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The status of the supernode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Using</para>
        /// </summary>
        [NameInMap("OperatingState")]
        [Validation(Required=false)]
        public string OperatingState { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6058705-1C45-35C9-9461-02504897D4D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxno4vh5****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The status of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        [Obsolete]
        public string Status { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-c</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
