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
        /// <para>Specify when NetTestType is CommTest.</para>
        /// </summary>
        [NameInMap("CommTest")]
        [Validation(Required=false)]
        public DescribeNetTestResultResponseBodyCommTest CommTest { get; set; }
        public class DescribeNetTestResultResponseBodyCommTest : TeaModel {
            /// <summary>
            /// <para>Number of GPUs</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GPUNum")]
            [Validation(Required=false)]
            public string GPUNum { get; set; }

            /// <summary>
            /// <para>All hosts infomation</para>
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
                /// <para>Service name.</para>
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
        /// <para>create time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-15T10:25:42+08:00</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>Fill in when the network test type is a delay test.</para>
        /// </summary>
        [NameInMap("DelayTest")]
        [Validation(Required=false)]
        public DescribeNetTestResultResponseBodyDelayTest DelayTest { get; set; }
        public class DescribeNetTestResultResponseBodyDelayTest : TeaModel {
            /// <summary>
            /// <para>All hosts infomation</para>
            /// </summary>
            [NameInMap("Hosts")]
            [Validation(Required=false)]
            public List<DescribeNetTestResultResponseBodyDelayTestHosts> Hosts { get; set; }
            public class DescribeNetTestResultResponseBodyDelayTestHosts : TeaModel {
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
                /// <para>The IP address.</para>
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
                /// <para>Service name.</para>
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
        /// <para>finish time</para>
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
        /// <para>Test port number.</para>
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
        /// <para>result detail</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ResultDetial")]
        [Validation(Required=false)]
        public string ResultDetial { get; set; }

        /// <summary>
        /// <para>status of session</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the test task. The unique identifier of a network test task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af35ce53-7c35-4277-834a-fbf49c316a96</para>
        /// </summary>
        [NameInMap("TestId")]
        [Validation(Required=false)]
        public string TestId { get; set; }

        /// <summary>
        /// <para>Fill in when the network test type is a traffic test.</para>
        /// </summary>
        [NameInMap("TrafficTest")]
        [Validation(Required=false)]
        public DescribeNetTestResultResponseBodyTrafficTest TrafficTest { get; set; }
        public class DescribeNetTestResultResponseBodyTrafficTest : TeaModel {
            /// <summary>
            /// <para>All clients information</para>
            /// </summary>
            [NameInMap("Clients")]
            [Validation(Required=false)]
            public List<DescribeNetTestResultResponseBodyTrafficTestClients> Clients { get; set; }
            public class DescribeNetTestResultResponseBodyTrafficTestClients : TeaModel {
                /// <summary>
                /// <para>Network interface bond port</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond1</para>
                /// </summary>
                [NameInMap("Bond")]
                [Validation(Required=false)]
                public string Bond { get; set; }

                /// <summary>
                /// <para>IP address.</para>
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
            /// <para>Call duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>When the protocol is RDMA, fill in True/False,
            /// when the protocol is TCP, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("GDR")]
            [Validation(Required=false)]
            public string GDR { get; set; }

            /// <summary>
            /// <para>Network protocol, either RDMA or TCP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>When the protocol is TCP, fill in the number of concurrent connections; when the protocol is RDMA, fill in the configured QP value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QP")]
            [Validation(Required=false)]
            public long? QP { get; set; }

            /// <summary>
            /// <para>Servers infomation.</para>
            /// </summary>
            [NameInMap("Servers")]
            [Validation(Required=false)]
            public List<DescribeNetTestResultResponseBodyTrafficTestServers> Servers { get; set; }
            public class DescribeNetTestResultResponseBodyTrafficTestServers : TeaModel {
                /// <summary>
                /// <para>Network interface bond port</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond1</para>
                /// </summary>
                [NameInMap("Bond")]
                [Validation(Required=false)]
                public string Bond { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
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
                /// <para>Service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xMv</para>
                /// </summary>
                [NameInMap("ServerName")]
                [Validation(Required=false)]
                public string ServerName { get; set; }

            }

            /// <summary>
            /// <para>Traffic model, either MTON or Fullmesh.</para>
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
