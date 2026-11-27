// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNetTestResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page for paging in a paged query. Maximum value: 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify the Settings or the specified Settings value is less than 20, the default value is 20.</para>
        /// </description></item>
        /// <item><description><para>If the specified Settings value is greater than 100, the default value is 100.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("NetTestResults")]
        [Validation(Required=false)]
        public List<ListNetTestResultsResponseBodyNetTestResults> NetTestResults { get; set; }
        public class ListNetTestResultsResponseBodyNetTestResults : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i11066721171826501****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The communication library test information. This field is populated when the traffic test type is communication library test.</para>
            /// </summary>
            [NameInMap("CommTest")]
            [Validation(Required=false)]
            public ListNetTestResultsResponseBodyNetTestResultsCommTest CommTest { get; set; }
            public class ListNetTestResultsResponseBodyNetTestResultsCommTest : TeaModel {
                /// <summary>
                /// <para>The number of GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("GPUNum")]
                [Validation(Required=false)]
                public string GPUNum { get; set; }

                /// <summary>
                /// <para>The hosts of the test nodes.</para>
                /// </summary>
                [NameInMap("Hosts")]
                [Validation(Required=false)]
                public List<ListNetTestResultsResponseBodyNetTestResultsCommTestHosts> Hosts { get; set; }
                public class ListNetTestResultsResponseBodyNetTestResultsCommTestHosts : TeaModel {
                    /// <summary>
                    /// <para>The node IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.51.16.21</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <para>The resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e01-cn-wwo3ete****</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.xinjiaoyu.com">www.xinjiaoyu.com</a></para>
                    /// </summary>
                    [NameInMap("ServerName")]
                    [Validation(Required=false)]
                    public string ServerName { get; set; }

                }

                /// <summary>
                /// <para>The communication library model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AllToAll</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The communication library test type. Valid values: ACCL and NCCL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACCL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The time is displayed in ISO 8601 format. Z in the example indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-19T02:18:12Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The delay test information. This field is populated when the network test type is delay test.</para>
            /// </summary>
            [NameInMap("DelayTest")]
            [Validation(Required=false)]
            public ListNetTestResultsResponseBodyNetTestResultsDelayTest DelayTest { get; set; }
            public class ListNetTestResultsResponseBodyNetTestResultsDelayTest : TeaModel {
                /// <summary>
                /// <para>The list of resources.</para>
                /// </summary>
                [NameInMap("Hosts")]
                [Validation(Required=false)]
                public List<ListNetTestResultsResponseBodyNetTestResultsDelayTestHosts> Hosts { get; set; }
                public class ListNetTestResultsResponseBodyNetTestResultsDelayTestHosts : TeaModel {
                    /// <summary>
                    /// <para>The NIC bond interface.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bond1</para>
                    /// </summary>
                    [NameInMap("Bond")]
                    [Validation(Required=false)]
                    public string Bond { get; set; }

                    /// <summary>
                    /// <para>The node IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pgm-bp174z988a27wre71o.pg.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <para>The resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e01-cn-wwo3ete****</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WrF</para>
                    /// </summary>
                    [NameInMap("ServerName")]
                    [Validation(Required=false)]
                    public string ServerName { get; set; }

                }

            }

            /// <summary>
            /// <para>The completion time. The time is displayed in ISO 8601 format. Z in the example indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-30T02:07Z</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// <para>The network test type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NetDiag</para>
            /// </summary>
            [NameInMap("NetTestType")]
            [Validation(Required=false)]
            public string NetTestType { get; set; }

            /// <summary>
            /// <para>The network mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("NetworkMode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// <para>The test port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The status of the network test task. Valid values:</br></para>
            /// <list type="bullet">
            /// <item><description>InProgress: The test is in progress.</br></description></item>
            /// <item><description>Finished: The test is completed.</br></description></item>
            /// <item><description>Failed: The test failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InProgress</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The test ID. The unique identifier of the resource test task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String	i-uf6i0tv2refv8wz*****</para>
            /// </summary>
            [NameInMap("TestId")]
            [Validation(Required=false)]
            public string TestId { get; set; }

            /// <summary>
            /// <para>The traffic test information. This field is populated when the network test type is traffic test.</para>
            /// </summary>
            [NameInMap("TrafficTest")]
            [Validation(Required=false)]
            public ListNetTestResultsResponseBodyNetTestResultsTrafficTest TrafficTest { get; set; }
            public class ListNetTestResultsResponseBodyNetTestResultsTrafficTest : TeaModel {
                /// <summary>
                /// <para>The clients.</para>
                /// </summary>
                [NameInMap("Clients")]
                [Validation(Required=false)]
                public List<ListNetTestResultsResponseBodyNetTestResultsTrafficTestClients> Clients { get; set; }
                public class ListNetTestResultsResponseBodyNetTestResultsTrafficTestClients : TeaModel {
                    /// <summary>
                    /// <para>The NIC bond interface.</para>
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
                    /// <para>74.73.100.1</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <para>The resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e01-cn-20p36bqet39</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prod-gf-cn.juequling.com</para>
                    /// </summary>
                    [NameInMap("ServerName")]
                    [Validation(Required=false)]
                    public string ServerName { get; set; }

                }

                /// <summary>
                /// <para>The duration of the workflow task, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>Indicates whether GDR is enabled when the protocol is RDMA. Valid values: True and False. This field is empty when the protocol is TCP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("GDR")]
                [Validation(Required=false)]
                public string GDR { get; set; }

                /// <summary>
                /// <para>The network protocol. Valid values: RDMA and TCP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The number of concurrent connections for the test when the protocol is TCP, or the configured QP value when the protocol is RDMA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("QP")]
                [Validation(Required=false)]
                public long? QP { get; set; }

                /// <summary>
                /// <para>The servers. This field is empty if the traffic model is Fullmesh.</para>
                /// </summary>
                [NameInMap("Servers")]
                [Validation(Required=false)]
                public List<ListNetTestResultsResponseBodyNetTestResultsTrafficTestServers> Servers { get; set; }
                public class ListNetTestResultsResponseBodyNetTestResultsTrafficTestServers : TeaModel {
                    /// <summary>
                    /// <para>The NIC bond interface.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bond1</para>
                    /// </summary>
                    [NameInMap("Bond")]
                    [Validation(Required=false)]
                    public string Bond { get; set; }

                    /// <summary>
                    /// <para>The node IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.1.168.183</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <para>The resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e01-cn-wwo3ete****</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prod-gf-cn.juequling.com</para>
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

        /// <summary>
        /// <para>The next token. Include this value in the request to query the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a6b93229825ac667104463b5679****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C683243-7915-57FB-9570-A2932C1C0F78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
