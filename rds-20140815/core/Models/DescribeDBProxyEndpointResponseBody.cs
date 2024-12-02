// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The proxy endpoint queried.</para>
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
        /// <item><description><b>InnerString</b>: internal network</description></item>
        /// <item><description><b>OuterString</b>: Internet</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InnerString</para>
        /// </summary>
        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        /// <summary>
        /// <para>The port number that is associated with the proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DBProxyConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyConnectStringPort { get; set; }

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
        /// <para>The configuration of the proxy terminal. The value of this parameter is a JSON string that consists of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>TransactionReadSqlRouteOptimizeStatus</b>: the status of the transaction splitting feature. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that the feature is disabled. The value 1 indicates that the feature is enabled.</description></item>
        /// <item><description><b>ConnectionPersist</b>: the status of the connection pooling feature. Valid values: <b>0</b>, <b>1</b>, and <b>2</b>. The value 0 indicates that the connection pooling feature is disabled. The value 1 indicates that the session-level connection pooling feature is enabled. The value 2 indicates that the transaction-level connection pooling feature is enabled.</description></item>
        /// <item><description><b>ReadWriteSpliting</b>: the status of the read/write splitting feature. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that the feature is disabled. The value 1 indicates that the feature is enabled.</description></item>
        /// <item><description><b>AZProximityAccess</b>: the status of the nearest access feature. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that the feature is disabled. The value 1 indicates that the feature is enabled.</description></item>
        /// <item><description><b>PinPreparedStmt</b>: an internal parameter that is available only for ApsaraDB RDS for PostgrSQL instances.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the instance runs PostgreSQL, you can change only the value of the <b>ReadWriteSpliting</b> field. The <b>TransactionReadSqlRouteOptimizeStatus</b> and <b>PinPreparedStmt</b> fields are set to their default values 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TransactionReadSqlRouteOptimizeStatus:1;ConnectionPersist:0;ReadWriteSpliting:1</para>
        /// </summary>
        [NameInMap("DBProxyFeatures")]
        [Validation(Required=false)]
        public string DBProxyFeatures { get; set; }

        /// <summary>
        /// <para>The proxy nodes that are associated with the proxy terminal.</para>
        /// </summary>
        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public DescribeDBProxyEndpointResponseBodyDBProxyNodes DBProxyNodes { get; set; }
        public class DescribeDBProxyEndpointResponseBodyDBProxyNodes : TeaModel {
            [NameInMap("DBProxyNodes")]
            [Validation(Required=false)]
            public List<DescribeDBProxyEndpointResponseBodyDBProxyNodesDBProxyNodes> DBProxyNodes { get; set; }
            public class DescribeDBProxyEndpointResponseBodyDBProxyNodesDBProxyNodes : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("cpuCores")]
                [Validation(Required=false)]
                public string CpuCores { get; set; }

                /// <summary>
                /// <para>The ID of the node in the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pn-xxxxxxx01</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The zone ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-c</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the proxy terminal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxyterminal-test</para>
        /// </summary>
        [NameInMap("DbProxyEndpointAliases")]
        [Validation(Required=false)]
        public string DbProxyEndpointAliases { get; set; }

        /// <summary>
        /// <para>The read and write attributes of the proxy terminal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: The proxy terminal supports read and write requests.</description></item>
        /// <item><description><b>ReadOnly</b>: The proxy terminal supports only read requests.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("DbProxyEndpointReadWriteMode")]
        [Validation(Required=false)]
        public string DbProxyEndpointReadWriteMode { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the proxy terminal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("DbProxyEndpointVswitchId")]
        [Validation(Required=false)]
        public string DbProxyEndpointVswitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the proxy terminal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("DbProxyEndpointZoneId")]
        [Validation(Required=false)]
        public string DbProxyEndpointZoneId { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about the proxy endpoint.</para>
        /// </summary>
        [NameInMap("EndpointConnectItems")]
        [Validation(Required=false)]
        public DescribeDBProxyEndpointResponseBodyEndpointConnectItems EndpointConnectItems { get; set; }
        public class DescribeDBProxyEndpointResponseBodyEndpointConnectItems : TeaModel {
            [NameInMap("EndpointConnectItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems> EndpointConnectItems { get; set; }
            public class DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems : TeaModel {
                /// <summary>
                /// <para>The proxy endpoint queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testproxy****.rwlb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("DbProxyEndpointConnectString")]
                [Validation(Required=false)]
                public string DbProxyEndpointConnectString { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Internet</description></item>
                /// <item><description><b>1</b>: classic network</description></item>
                /// <item><description><b>2</b>: virtual private cloud (VPC)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DbProxyEndpointNetType")]
                [Validation(Required=false)]
                public string DbProxyEndpointNetType { get; set; }

                /// <summary>
                /// <para>The port number that is associated with the proxy endpoint. Default value: <b>3306</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("DbProxyEndpointPort")]
                [Validation(Required=false)]
                public string DbProxyEndpointPort { get; set; }

            }

        }

        /// <summary>
        /// <para>The method that is used to assign read weights. For more information, see <a href="https://help.aliyun.com/document_detail/96076.html">Modify the latency threshold and read weights of ApsaraDB RDS for MySQL instances</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: The system automatically assigns read weights to the instance and its read-only instances based on the specifications of these instances.</description></item>
        /// <item><description><b>Custom</b>: You must manually assign read weights to the instance and its read-only instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceDistributionType")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceDistributionType { get; set; }

        /// <summary>
        /// <para>The latency threshold that is allowed for read/write splitting. If the latency on a read-only instance exceeds the specified threshold, ApsaraDB RDS no longer forwards read requests to the read-only instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceMaxDelayTime")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceMaxDelayTime { get; set; }

        /// <summary>
        /// <para>The read weights of the instance and its read-only instances. The value of this parameter is a JSON string that consists of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>DBInstanceId</b>: the ID of the instance.</description></item>
        /// <item><description><b>DBInstanceType</b>: the role of the instance. Valid values: <b>Master</b> and <b>ReadOnly</b>.</description></item>
        /// <item><description><b>NodeID</b>: The IDs of the primary and secondary nodes of the cluster. An instance that runs RDS Cluster Edition refers to a cluster.</description></item>
        /// <item><description><b>NodeType</b>: The node type. Valid values: <b>Primary</b> and <b>Secondary</b>.</description></item>
        /// <item><description><b>Weight</b>: the read weight of the instance. The read weight increases in increments of <b>100</b> and cannot exceed <b>10000</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Availability\&quot;:\&quot;Available\&quot;,\&quot;DBInstanceId\&quot;:\&quot;rr-bp176984qewd8****\&quot;,\&quot;DBInstanceType\&quot;:\&quot;ReadOnly\&quot;,\&quot;Weight\&quot;:400},{\&quot;Availability\&quot;:\&quot;Available\&quot;,\&quot;DBInstanceId\&quot;:\&quot;rm-bp1ja4f56s7us****\&quot;,\&quot;DBInstanceType\&quot;:\&quot;Master\&quot;,\&quot;Weight\&quot;:0}]</para>
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
