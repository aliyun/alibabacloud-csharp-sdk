// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNetTestResultsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NetTestResults")]
        [Validation(Required=false)]
        public List<ListNetTestResultsResponseBodyNetTestResults> NetTestResults { get; set; }
        public class ListNetTestResultsResponseBodyNetTestResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i110667211718265012218</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("CommTest")]
            [Validation(Required=false)]
            public ListNetTestResultsResponseBodyNetTestResultsCommTest CommTest { get; set; }
            public class ListNetTestResultsResponseBodyNetTestResultsCommTest : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("GPUNum")]
                [Validation(Required=false)]
                public string GPUNum { get; set; }

                [NameInMap("Hosts")]
                [Validation(Required=false)]
                public List<ListNetTestResultsResponseBodyNetTestResultsCommTestHosts> Hosts { get; set; }
                public class ListNetTestResultsResponseBodyNetTestResultsCommTestHosts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10.51.16.21</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e01-cn-wwo3eteze19</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://www.xinjiaoyu.com">www.xinjiaoyu.com</a></para>
                    /// </summary>
                    [NameInMap("ServerName")]
                    [Validation(Required=false)]
                    public string ServerName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AllToAll</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACCL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-19T02:18:12Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DelayTest")]
            [Validation(Required=false)]
            public ListNetTestResultsResponseBodyNetTestResultsDelayTest DelayTest { get; set; }
            public class ListNetTestResultsResponseBodyNetTestResultsDelayTest : TeaModel {
                [NameInMap("Hosts")]
                [Validation(Required=false)]
                public List<ListNetTestResultsResponseBodyNetTestResultsDelayTestHosts> Hosts { get; set; }
                public class ListNetTestResultsResponseBodyNetTestResultsDelayTestHosts : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bond1</para>
                    /// </summary>
                    [NameInMap("Bond")]
                    [Validation(Required=false)]
                    public string Bond { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pgm-bp174z988a27wre71o.pg.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e01-cn-wwo3eteze19</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>WrF</para>
                    /// </summary>
                    [NameInMap("ServerName")]
                    [Validation(Required=false)]
                    public string ServerName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-30T02:07Z</para>
            /// </summary>
            [NameInMap("FinishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NetDiag</para>
            /// </summary>
            [NameInMap("NetTestType")]
            [Validation(Required=false)]
            public string NetTestType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("NetworkMode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InProgress</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>String	i-uf6i0tv2refv8wz*****</para>
            /// </summary>
            [NameInMap("TestId")]
            [Validation(Required=false)]
            public string TestId { get; set; }

            [NameInMap("TrafficTest")]
            [Validation(Required=false)]
            public ListNetTestResultsResponseBodyNetTestResultsTrafficTest TrafficTest { get; set; }
            public class ListNetTestResultsResponseBodyNetTestResultsTrafficTest : TeaModel {
                [NameInMap("Clients")]
                [Validation(Required=false)]
                public List<ListNetTestResultsResponseBodyNetTestResultsTrafficTestClients> Clients { get; set; }
                public class ListNetTestResultsResponseBodyNetTestResultsTrafficTestClients : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bond1</para>
                    /// </summary>
                    [NameInMap("Bond")]
                    [Validation(Required=false)]
                    public string Bond { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>74.73.100.1</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e01-cn-20p36bqet39</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>prod-gf-cn.juequling.com</para>
                    /// </summary>
                    [NameInMap("ServerName")]
                    [Validation(Required=false)]
                    public string ServerName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("GDR")]
                [Validation(Required=false)]
                public string GDR { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RDMA</para>
                /// </summary>
                [NameInMap("QP")]
                [Validation(Required=false)]
                public long? QP { get; set; }

                [NameInMap("Servers")]
                [Validation(Required=false)]
                public List<ListNetTestResultsResponseBodyNetTestResultsTrafficTestServers> Servers { get; set; }
                public class ListNetTestResultsResponseBodyNetTestResultsTrafficTestServers : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bond1</para>
                    /// </summary>
                    [NameInMap("Bond")]
                    [Validation(Required=false)]
                    public string Bond { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10.1.168.183</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e01-cn-wwo3eteze19</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>prod-gf-cn.juequling.com</para>
                    /// </summary>
                    [NameInMap("ServerName")]
                    [Validation(Required=false)]
                    public string ServerName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Fullmesh</para>
                /// </summary>
                [NameInMap("TrafficModel")]
                [Validation(Required=false)]
                public string TrafficModel { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3a6b93229825ac667104463b56790c91</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C683243-7915-57FB-9570-A2932C1C0F78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
