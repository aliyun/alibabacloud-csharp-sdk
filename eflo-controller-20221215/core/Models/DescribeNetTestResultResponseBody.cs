// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNetTestResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i119982311660892626523</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The configuration for the communication library test. This parameter is returned when the network test type is a communication library test.</para>
        /// </summary>
        [NameInMap("CommTest")]
        [Validation(Required=false)]
        public DescribeNetTestResultResponseBodyCommTest CommTest { get; set; }
        public class DescribeNetTestResultResponseBodyCommTest : TeaModel {
            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GPUNum")]
            [Validation(Required=false)]
            public string GPUNum { get; set; }

            /// <summary>
            /// <para>The hosts for the test.</para>
            /// </summary>
            [NameInMap("Hosts")]
            [Validation(Required=false)]
            public List<DescribeNetTestResultResponseBodyCommTestHosts> Hosts { get; set; }
            public class DescribeNetTestResultResponseBodyCommTestHosts : TeaModel {
                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.253.253.15</para>
                /// </summary>
                [NameInMap("IP")]
                [Validation(Required=false)]
                public string IP { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i111670831721110797708</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VBw</para>
                /// </summary>
                [NameInMap("ServerName")]
                [Validation(Required=false)]
                public string ServerName { get; set; }

            }

            /// <summary>
            /// <para>The communication library model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intention_v4</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The type of the communication library test. Valid values: Alibaba Cloud Collective Communication Library (ACCL) and NVIDIA Collective Communication Library (NCCL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACCL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The time when the diagnostic task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-15T10:25:42+08:00</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The configuration for the delay test. This parameter is returned when the network test type is a delay test.</para>
        /// </summary>
        [NameInMap("DelayTest")]
        [Validation(Required=false)]
        public DescribeNetTestResultResponseBodyDelayTest DelayTest { get; set; }
        public class DescribeNetTestResultResponseBodyDelayTest : TeaModel {
            /// <summary>
            /// <para>The hosts of the test nodes.</para>
            /// </summary>
            [NameInMap("Hosts")]
            [Validation(Required=false)]
            public List<DescribeNetTestResultResponseBodyDelayTestHosts> Hosts { get; set; }
            public class DescribeNetTestResultResponseBodyDelayTestHosts : TeaModel {
                /// <summary>
                /// <para>The bonded port of the NIC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond1</para>
                /// </summary>
                [NameInMap("Bond")]
                [Validation(Required=false)]
                public string Bond { get; set; }

                /// <summary>
                /// <para>The IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>125.210.225.48</para>
                /// </summary>
                [NameInMap("IP")]
                [Validation(Required=false)]
                public string IP { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-bcd3u1aee06</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NQU</para>
                /// </summary>
                [NameInMap("ServerName")]
                [Validation(Required=false)]
                public string ServerName { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the diagnostic task was completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16T02:04Z</para>
        /// </summary>
        [NameInMap("FinishedTime")]
        [Validation(Required=false)]
        public string FinishedTime { get; set; }

        /// <summary>
        /// <para>The type of the network test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DelayTest</para>
        /// </summary>
        [NameInMap("NetTestType")]
        [Validation(Required=false)]
        public string NetTestType { get; set; }

        /// <summary>
        /// <para>The test port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23604</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F065DDD-6996-5973-9691-9EC57BD0072E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the diagnostic result. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ResultDetial")]
        [Validation(Required=false)]
        public string ResultDetial { get; set; }

        /// <summary>
        /// <para>The status of the diagnostic task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>InProgress: The task is in progress.</para>
        /// </description></item>
        /// <item><description><para>Finished: The task is complete.</para>
        /// </description></item>
        /// <item><description><para>Failed: The task failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Failed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the test task. This ID uniquely identifies the network test task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af35ce53-7c35-4277-834a-fbf49c316a96</para>
        /// </summary>
        [NameInMap("TestId")]
        [Validation(Required=false)]
        public string TestId { get; set; }

        /// <summary>
        /// <para>The configuration for the traffic test. This parameter is returned when the network test type is a traffic test.</para>
        /// </summary>
        [NameInMap("TrafficTest")]
        [Validation(Required=false)]
        public DescribeNetTestResultResponseBodyTrafficTest TrafficTest { get; set; }
        public class DescribeNetTestResultResponseBodyTrafficTest : TeaModel {
            /// <summary>
            /// <para>The client nodes.</para>
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<DescribeNetTestResultResponseBodyTrafficTestClients> Clients { get; set; }
            public class DescribeNetTestResultResponseBodyTrafficTestClients : TeaModel {
                /// <summary>
                /// <para>The bonded port of the network interface card (NIC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond1</para>
                /// </summary>
                [NameInMap("Bond")]
                [Validation(Required=false)]
                public string Bond { get; set; }

                /// <summary>
                /// <para>The IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("IP")]
                [Validation(Required=false)]
                public string IP { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-20s41p6cx01</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xMv</para>
                /// </summary>
                [NameInMap("ServerName")]
                [Validation(Required=false)]
                public string ServerName { get; set; }

            }

            /// <summary>
            /// <para>The runtime of the flow task in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Indicates whether GPUDirect RDMA (GDR) is enabled. This parameter is returned only if the protocol is RDMA. Valid values: True and False. If the protocol is TCP, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("GDR")]
            [Validation(Required=false)]
            public string GDR { get; set; }

            /// <summary>
            /// <para>The network protocol. Valid values: Remote Direct Memory Access (RDMA) and Transmission Control Protocol (TCP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>If the protocol is TCP, this is the number of concurrent connections for the test. If the protocol is RDMA, this is the Queue Pair (QP) value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QP")]
            [Validation(Required=false)]
            public long? QP { get; set; }

            /// <summary>
            /// <para>The list of servers.</para>
            /// </summary>
            [NameInMap("Servers")]
            [Validation(Required=false)]
            public List<DescribeNetTestResultResponseBodyTrafficTestServers> Servers { get; set; }
            public class DescribeNetTestResultResponseBodyTrafficTestServers : TeaModel {
                /// <summary>
                /// <para>The bonded port of the NIC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond1</para>
                /// </summary>
                [NameInMap("Bond")]
                [Validation(Required=false)]
                public string Bond { get; set; }

                /// <summary>
                /// <para>The IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.121.110.190</para>
                /// </summary>
                [NameInMap("IP")]
                [Validation(Required=false)]
                public string IP { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-wwo3etaqu0b</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xMv</para>
                /// </summary>
                [NameInMap("ServerName")]
                [Validation(Required=false)]
                public string ServerName { get; set; }

            }

            /// <summary>
            /// <para>The traffic model. Valid values: MTON and Fullmesh.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fullmesh</para>
            /// </summary>
            [NameInMap("TrafficModel")]
            [Validation(Required=false)]
            public string TrafficModel { get; set; }

        }

    }

}
