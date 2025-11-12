// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeHyperNodeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i119982311660892626523</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-11-30T02:00:00.852Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2125-06-24T16:52:44.318000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alywlcb-lingjun-gpu-0025</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A1</para>
        /// </summary>
        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("HyperNodeId")]
        [Validation(Required=false)]
        public string HyperNodeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>efg1.nvga1</para>
        /// </summary>
        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ng-ec3c96ff0aa4c60d</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lisan-nodegroup</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeHyperNodeResponseBodyNodes> Nodes { get; set; }
        public class DescribeHyperNodeResponseBodyNodes : TeaModel {
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeHyperNodeResponseBodyNodesDisks> Disks { get; set; }
            public class DescribeHyperNodeResponseBodyNodesDisks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DOWNLINK_PACKET</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d-bp1564bcc2306uui4zpk</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PL0</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>457db5ca-241d-11ed-9fd7-acde48001122</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i190297201669099844192</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Alinux3_x86_gu8xf_P_Host_D3_C7E3_550.127_Legacy_N_241230</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("Networks")]
            [Validation(Required=false)]
            public DescribeHyperNodeResponseBodyNodesNetworks Networks { get; set; }
            public class DescribeHyperNodeResponseBodyNodesNetworks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>bond0</para>
                /// </summary>
                [NameInMap("BondName")]
                [Validation(Required=false)]
                public string BondName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.22.2</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e01-cn-zvp2tgykr0b</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Using</para>
            /// </summary>
            [NameInMap("OperatingState")]
            [Validation(Required=false)]
            public string OperatingState { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para>InProgress</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            [Obsolete]
            public string Status { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>Using</para>
        /// </summary>
        [NameInMap("OperatingState")]
        [Validation(Required=false)]
        public string OperatingState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D6058705-1C45-35C9-9461-02504897D4D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmxno4vh5****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>Operating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        [Obsolete]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-c</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
