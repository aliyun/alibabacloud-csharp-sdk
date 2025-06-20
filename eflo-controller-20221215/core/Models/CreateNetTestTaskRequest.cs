// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateNetTestTaskRequest : TeaModel {
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
        /// <para>Eflo-YJ-Test-Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>Specify when NetTestType is CommTest.</para>
        /// </summary>
        [NameInMap("CommTest")]
        [Validation(Required=false)]
        public CreateNetTestTaskRequestCommTest CommTest { get; set; }
        public class CreateNetTestTaskRequestCommTest : TeaModel {
            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GPUNum")]
            [Validation(Required=false)]
            public long? GPUNum { get; set; }

            /// <summary>
            /// <para>The host IDs.</para>
            /// </summary>
            [NameInMap("Hosts")]
            [Validation(Required=false)]
            public List<CreateNetTestTaskRequestCommTestHosts> Hosts { get; set; }
            public class CreateNetTestTaskRequestCommTestHosts : TeaModel {
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-tw-bqisacl3z6l</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

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
                /// <para>The name of the service.</para>
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
            /// <para>The CommTest type, which can be ACCL or NCCL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACCL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Specify when NetTestType is DelayTest.</para>
        /// </summary>
        [NameInMap("DelayTest")]
        [Validation(Required=false)]
        public CreateNetTestTaskRequestDelayTest DelayTest { get; set; }
        public class CreateNetTestTaskRequestDelayTest : TeaModel {
            /// <summary>
            /// <para>The hosts of the test node.</para>
            /// </summary>
            [NameInMap("Hosts")]
            [Validation(Required=false)]
            public List<CreateNetTestTaskRequestDelayTestHosts> Hosts { get; set; }
            public class CreateNetTestTaskRequestDelayTestHosts : TeaModel {
                /// <summary>
                /// <para>The bonding of network interface card.</para>
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-fou43an0a05</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

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
                /// <para>The name of the service.</para>
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
        /// <para>The type of the network test. Valid values: DelayTest, TrafficTest, and CommTest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DelayTest</para>
        /// </summary>
        [NameInMap("NetTestType")]
        [Validation(Required=false)]
        public string NetTestType { get; set; }

        /// <summary>
        /// <para>The network mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>The port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23604</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>If the TrafficModel is Fullmesh, leave this parameter empty.</para>
        /// </summary>
        [NameInMap("TrafficTest")]
        [Validation(Required=false)]
        public CreateNetTestTaskRequestTrafficTest TrafficTest { get; set; }
        public class CreateNetTestTaskRequestTrafficTest : TeaModel {
            /// <summary>
            /// <para>The client IDs.</para>
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<CreateNetTestTaskRequestTrafficTestClients> Clients { get; set; }
            public class CreateNetTestTaskRequestTrafficTestClients : TeaModel {
                /// <summary>
                /// <para>The bonding of network interface card.</para>
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-tw-w5elqg7pw18</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

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
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xMv</para>
                /// </summary>
                [NameInMap("ServerName")]
                [Validation(Required=false)]
                public string ServerName { get; set; }

            }

            /// <summary>
            /// <para>The running duration of the pipeline job. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>If the protocol is RDMA, enter True or False. If the protocol is TCP, leave this field empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("GDR")]
            [Validation(Required=false)]
            public bool? GDR { get; set; }

            /// <summary>
            /// <para>The network protocol, which can be RDMA or TCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>If the protocol is TCP, enter the number of concurrent connections. If the protocol is RDMA, enter the configured QP value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QP")]
            [Validation(Required=false)]
            public long? QP { get; set; }

            /// <summary>
            /// <para>The services.</para>
            /// </summary>
            [NameInMap("Servers")]
            [Validation(Required=false)]
            public List<CreateNetTestTaskRequestTrafficTestServers> Servers { get; set; }
            public class CreateNetTestTaskRequestTrafficTestServers : TeaModel {
                /// <summary>
                /// <para>The bonding of network interface card.</para>
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-tw-bqisacl3z6l</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

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
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xMv</para>
                /// </summary>
                [NameInMap("ServerName")]
                [Validation(Required=false)]
                public string ServerName { get; set; }

            }

            /// <summary>
            /// <para>The traffic model, which can be MTON or Fullmesh.</para>
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
