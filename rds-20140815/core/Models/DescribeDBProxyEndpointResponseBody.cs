// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The timeout period for consistency reads. Unit: milliseconds. Default value: <b>10</b>. Valid values: <b>0 to 60000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CausalConsistReadTimeout")]
        [Validation(Required=false)]
        public string CausalConsistReadTimeout { get; set; }

        /// <summary>
        /// <para>The proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testproxy****.rwlb.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DBProxyConnectString")]
        [Validation(Required=false)]
        public string DBProxyConnectString { get; set; }

        /// <summary>
        /// <para>The network type of the proxy endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>InnerString</b>: internal endpoint.</description></item>
        /// <item><description><b>OuterString</b>: public endpoint.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InnerString</para>
        /// </summary>
        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        /// <summary>
        /// <para>The port of the proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DBProxyConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyConnectStringPort { get; set; }

        [NameInMap("DBProxyEndpointCostThresholdForDuckdb")]
        [Validation(Required=false)]
        public string DBProxyEndpointCostThresholdForDuckdb { get; set; }

        /// <summary>
        /// <para>The ID of the proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keaxncrjluwu0gue****</para>
        /// </summary>
        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        /// <summary>
        /// <para>The minimum number of reserved instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBProxyEndpointMinSlaveCount")]
        [Validation(Required=false)]
        public string DBProxyEndpointMinSlaveCount { get; set; }

        /// <summary>
        /// <para>An internal parameter. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The settings of the proxy endpoint in JSON format. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description><b>TransactionReadSqlRouteOptimizeStatus</b>: the transaction splitting setting. The value is <b>0</b> (disabled) or <b>1</b> (enabled).</description></item>
        /// <item><description><b>ConnectionPersist</b>: the connection pool setting. The value is <b>0</b> (disabled), <b>1</b> (session-level connection pool), or <b>2</b> (transaction-level connection pooling).</description></item>
        /// <item><description><b>ReadWriteSpliting</b>: the read/write splitting setting. The value is <b>0</b> (disabled) or <b>1</b> (enabled).</description></item>
        /// <item><description><b>AZProximityAccess</b>: the nearest access feature. The value is <b>0</b> (disabled) or <b>1</b> (enabled).</description></item>
        /// <item><description><b>CausalConsistRead</b>: the read consistency setting. The value is <b>0</b> (eventual consistency), <b>1</b> (session consistency), or <b>2</b> (global consistency).</description></item>
        /// <item><description><b>HtapFilter</b>: the automatic request distribution among row store and column store nodes setting. The value is <b>0</b> (disabled) or <b>1</b> (enabled).</description></item>
        /// <item><description><b>PinPreparedStmt</b>: visible only for ApsaraDB RDS for PostgreSQL. This is an internal parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <para>ApsaraDB RDS for PostgreSQL supports modification of only <b>ReadWriteSpliting</b>. <b>TransactionReadSqlRouteOptimizeStatus</b> and <b>PinPreparedStmt</b> are set to 1 by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TransactionReadSqlRouteOptimizeStatus:1;ConnectionPersist:0;ReadWriteSpliting:1</para>
        /// </summary>
        [NameInMap("DBProxyFeatures")]
        [Validation(Required=false)]
        public string DBProxyFeatures { get; set; }

        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public DescribeDBProxyEndpointResponseBodyDBProxyNodes DBProxyNodes { get; set; }
        public class DescribeDBProxyEndpointResponseBodyDBProxyNodes : TeaModel {
            [NameInMap("DBProxyNodes")]
            [Validation(Required=false)]
            public List<DescribeDBProxyEndpointResponseBodyDBProxyNodesDBProxyNodes> DBProxyNodes { get; set; }
            public class DescribeDBProxyEndpointResponseBodyDBProxyNodesDBProxyNodes : TeaModel {
                [NameInMap("cpuCores")]
                [Validation(Required=false)]
                public string CpuCores { get; set; }

                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxyterminal-test</para>
        /// </summary>
        [NameInMap("DbProxyEndpointAliases")]
        [Validation(Required=false)]
        public string DbProxyEndpointAliases { get; set; }

        /// <summary>
        /// <para>The read/write type of the proxy endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: read/write splitting mode.</description></item>
        /// <item><description><b>ReadOnly</b>: read-only mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("DbProxyEndpointReadWriteMode")]
        [Validation(Required=false)]
        public string DbProxyEndpointReadWriteMode { get; set; }

        /// <summary>
        /// <para>The VPC ID of the proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("DbProxyEndpointVpcId")]
        [Validation(Required=false)]
        public string DbProxyEndpointVpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("DbProxyEndpointVswitchId")]
        [Validation(Required=false)]
        public string DbProxyEndpointVswitchId { get; set; }

        /// <summary>
        /// <para>The zone information of the proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("DbProxyEndpointZoneId")]
        [Validation(Required=false)]
        public string DbProxyEndpointZoneId { get; set; }

        [NameInMap("EndpointConnectItems")]
        [Validation(Required=false)]
        public DescribeDBProxyEndpointResponseBodyEndpointConnectItems EndpointConnectItems { get; set; }
        public class DescribeDBProxyEndpointResponseBodyEndpointConnectItems : TeaModel {
            [NameInMap("EndpointConnectItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems> EndpointConnectItems { get; set; }
            public class DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems : TeaModel {
                [NameInMap("DbProxyEndpointConnectString")]
                [Validation(Required=false)]
                public string DbProxyEndpointConnectString { get; set; }

                [NameInMap("DbProxyEndpointNetType")]
                [Validation(Required=false)]
                public string DbProxyEndpointNetType { get; set; }

                [NameInMap("DbProxyEndpointPort")]
                [Validation(Required=false)]
                public string DbProxyEndpointPort { get; set; }

            }

        }

        /// <summary>
        /// <para>The read weight distribution mode. For more information, see <a href="https://help.aliyun.com/document_detail/96076.html">Read weight distribution</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: automatically distributes weights based on instance specifications.</description></item>
        /// <item><description><b>Custom</b>: uses custom weight distribution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceDistributionType")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceDistributionType { get; set; }

        /// <summary>
        /// <para>The latency threshold for read/write splitting. When the latency of a read-only instance exceeds this threshold, read traffic is not routed to the instance. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceMaxDelayTime")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceMaxDelayTime { get; set; }

        /// <summary>
        /// <para>The read weight distribution information, which specifies the read request weights of the primary instance and read-only instances. The value is in JSON format and includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>DBInstanceId</b>: the instance ID.</description></item>
        /// <item><description><b>DBInstanceType</b>: the instance type. The value is <b>Master</b> (primary instance) or <b>ReadOnly</b> (read-only instance).</description></item>
        /// <item><description><b>NodeID</b>: the node ID of the primary node or secondary node of the primary instance in the Cluster Edition.</description></item>
        /// <item><description><b>NodeType</b>: the node type in the Cluster Edition. The value is <b>Primary</b> (primary node of the primary instance) or <b>Secondary</b> (secondary node of the primary instance).</description></item>
        /// <item><description><b>Weight</b>: the read request weight. The value increases in increments of <b>100</b>. Maximum value: <b>10000</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Availability\&quot;:\&quot;Available\&quot;,\&quot;DBInstanceId\&quot;:\&quot;rm-2z****\&quot;，\&quot;DBInstanceType\&quot;:\&quot;Master\&quot;,\&quot;NodeId\&quot;:\&quot;rn-t2****\&quot;,\&quot;NodeType\&quot;:\&quot;Primary\&quot;,\&quot;Weight\&quot;:0}, {\&quot;Availability\&quot;:\&quot;Available\&quot;,\&quot;DBInstanceId\&quot;:\&quot;rm-2z****\&quot;，\&quot;DBInstanceType\&quot;:\&quot;Master\&quot;,\&quot;NodeId\&quot;:\&quot;rn-z9****\&quot;,\&quot;NodeType\&quot;:\&quot;Secondary\&quot;,\&quot;Weight\&quot;:400}, {\&quot;Availability\&quot;:\&quot;Available\&quot;,,\&quot;DBInstanceId\&quot;:\&quot;rm-2z****\&quot;，\&quot;DBInstanceType\&quot;:\&quot;Master\&quot;,\&quot;NodeId\&quot;:\&quot;rn-1c****\&quot;,\&quot;NodeType\&quot;:\&quot;Secondary\&quot;,\&quot;Weight\&quot;:400}]]</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceWeight")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceWeight { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>847BA085-B377-4BFA-8267-F82345ECE1D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
