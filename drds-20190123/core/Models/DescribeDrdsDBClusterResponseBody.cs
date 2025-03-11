// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDBClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of each PolarDB cluster.</para>
        /// </summary>
        [NameInMap("DbInstance")]
        [Validation(Required=false)]
        public DescribeDrdsDBClusterResponseBodyDbInstance DbInstance { get; set; }
        public class DescribeDrdsDBClusterResponseBodyDbInstance : TeaModel {
            /// <summary>
            /// <para>The ID of the PolarDB cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The status of the PolarDB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DBInstanceStatus")]
            [Validation(Required=false)]
            public string DBInstanceStatus { get; set; }

            /// <summary>
            /// <para>The information about the nodes in the PolarDB Cluster.</para>
            /// </summary>
            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public DescribeDrdsDBClusterResponseBodyDbInstanceDBNodes DBNodes { get; set; }
            public class DescribeDrdsDBClusterResponseBodyDbInstanceDBNodes : TeaModel {
                [NameInMap("DBNode")]
                [Validation(Required=false)]
                public List<DescribeDrdsDBClusterResponseBodyDbInstanceDBNodesDBNode> DBNode { get; set; }
                public class DescribeDrdsDBClusterResponseBodyDbInstanceDBNodesDBNode : TeaModel {
                    /// <summary>
                    /// <para>The ID of the node in the apsaradb for PolarDB cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pi-***************</para>
                    /// </summary>
                    [NameInMap("DBNodeId")]
                    [Validation(Required=false)]
                    public string DBNodeId { get; set; }

                    /// <summary>
                    /// <para>The role of a node in the apsaradb for PolarDB cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Reader</b></description></item>
                    /// <item><description><b>Writer</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reader</para>
                    /// </summary>
                    [NameInMap("DBNodeRole")]
                    [Validation(Required=false)]
                    public string DBNodeRole { get; set; }

                    /// <summary>
                    /// <para>The status of the nodes in the PolarDB cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Running</para>
                    /// </summary>
                    [NameInMap("DBNodeStatus")]
                    [Validation(Required=false)]
                    public string DBNodeStatus { get; set; }

                    /// <summary>
                    /// <para>The ID of the zone where the node of the PolarDB cluster resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-i</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            /// <summary>
            /// <para>The type of storage used by the DRDS database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POLARDB</para>
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public string DbInstType { get; set; }

            /// <summary>
            /// <para>The endpoint of the PolarDB read /write splitting endpoint</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public DescribeDrdsDBClusterResponseBodyDbInstanceEndpoints Endpoints { get; set; }
            public class DescribeDrdsDBClusterResponseBodyDbInstanceEndpoints : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public List<DescribeDrdsDBClusterResponseBodyDbInstanceEndpointsEndpoint> Endpoint { get; set; }
                public class DescribeDrdsDBClusterResponseBodyDbInstanceEndpointsEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The ID of the PolarDB connection address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pe-*****************</para>
                    /// </summary>
                    [NameInMap("EndpointId")]
                    [Validation(Required=false)]
                    public string EndpointId { get; set; }

                    /// <summary>
                    /// <para>The ID list of the nodes in the PolarDB connection string. Separate multiple nodes with commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pi-<em><b><b><b><b><b><b><b><b>,pi-</b></b></b></b></b></b></b></b></em></para>
                    /// </summary>
                    [NameInMap("NodeIds")]
                    [Validation(Required=false)]
                    public string NodeIds { get; set; }

                    /// <summary>
                    /// <para>The read ratio of this connection address managed by the DRDS database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>85</para>
                    /// </summary>
                    [NameInMap("ReadWeight")]
                    [Validation(Required=false)]
                    public int? ReadWeight { get; set; }

                }

            }

            /// <summary>
            /// <para>The type of the DRDS database storage engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POLARDB</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The version of the DRDS database storage engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The time when the PolarDB cluster expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-09-27 11:22:33</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The network type of the PolarDB cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The billing method of the PolarDB cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The PolarDB access port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The type of RDS instance. PolarDB cluster does not support this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("RdsInstType")]
            [Validation(Required=false)]
            public string RdsInstType { get; set; }

            /// <summary>
            /// <para>This parameter specifies the Read mode when the database storage type is PolarDB.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DEFAULT</b>: the default mode (that is, all read traffic is sent to the PolarDB read /write node).</description></item>
            /// <item><description><b>CUSTOM</b>: Custom mode (you can customize the ratio of traffic sent to read /write nodes and read-only nodes).</description></item>
            /// <item><description><b>BALANCE</b>: read balancing mode (the read traffic is automatically distributed by the read load module of the PolarDB cluster, which can also be understood as the read traffic being evenly distributed to each node).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("ReadMode")]
            [Validation(Required=false)]
            public string ReadMode { get; set; }

            /// <summary>
            /// <para>The number of days remaining on the PolarDB for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public string RemainDays { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60A77FD6-0DE4-4A34-B6FB-9C2673******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
