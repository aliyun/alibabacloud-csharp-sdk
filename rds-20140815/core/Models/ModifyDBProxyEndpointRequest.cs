// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The timeout period for read consistency. Unit: milliseconds. Default value: <b>10</b>. Valid values: <b>0</b> to <b>60000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CausalConsistReadTimeout")]
        [Validation(Required=false)]
        public string CausalConsistReadTimeout { get; set; }

        /// <summary>
        /// <para>Specifies the proxy features to be enabled for the proxy endpoint. Separate multiple features with semicolons (;). Format: <c>Feature 1:Status;Feature 2:Status;...</c>. Do not add a semicolon (;) at the end.</para>
        /// <para>Valid values for features:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWriteSpliting</b>: Read/write splitting.</description></item>
        /// <item><description><b>ConnectionPersist</b>: Connection pool.</description></item>
        /// <item><description><b>TransactionReadSqlRouteOptimizeStatus</b>: Transaction splitting.</description></item>
        /// <item><description><b>AZProximityAccess</b>: Nearest access.</description></item>
        /// <item><description><b>CausalConsistRead</b>: Read consistency.</description></item>
        /// <item><description><b>HtapFilter</b>: Automatic request distribution among row store and column store nodes for HTAP.</description></item>
        /// </list>
        /// <para>Valid values for the status:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The feature is enabled.</description></item>
        /// <item><description><b>0</b>: The feature is disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for PostgreSQL supports only <b>ReadWriteSpliting</b>.</description></item>
        /// <item><description>The nearest access feature is supported only by dedicated database proxies for MySQL.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWriteSpliting:1;ConnectionPersist:0</para>
        /// </summary>
        [NameInMap("ConfigDBProxyFeatures")]
        [Validation(Required=false)]
        public string ConfigDBProxyFeatures { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp145737x5bi6****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the proxy endpoint. You can call the DescribeDBProxyEndpoint operation to query the ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>MySQL: This parameter is required when <b>DbEndpointOperator</b> is set to <b>Delete</b> or <b>Modify</b>.</description></item>
        /// <item><description>PostgreSQL: This parameter is required when <b>DbEndpointOperator</b> is set to <b>Delete</b>, <b>Modify</b>, or <b>Create</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gos787jog2wk0y****</para>
        /// </summary>
        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and does not need to be configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The description of the proxy endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-proxy</para>
        /// </summary>
        [NameInMap("DbEndpointAliases")]
        [Validation(Required=false)]
        public string DbEndpointAliases { get; set; }

        /// <summary>
        /// <para>The execution cost threshold for SQL statements in automatic request distribution among row store and column store nodes for HTAP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("DbEndpointCostThresholdForDuckdb")]
        [Validation(Required=false)]
        public string DbEndpointCostThresholdForDuckdb { get; set; }

        /// <summary>
        /// <para>The minimum number of reserved instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DbEndpointMinSlaveCount")]
        [Validation(Required=false)]
        public string DbEndpointMinSlaveCount { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Modify</b>: Modifies the proxy endpoint. This is the default value.</description></item>
        /// <item><description><b>Create</b>: Creates a proxy endpoint.</description></item>
        /// <item><description><b>Delete</b>: Deletes a proxy endpoint.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Modify</para>
        /// </summary>
        [NameInMap("DbEndpointOperator")]
        [Validation(Required=false)]
        public string DbEndpointOperator { get; set; }

        /// <summary>
        /// <para>The read/write mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: Connects to the primary instance and can accept write requests.</description></item>
        /// <item><description><b>ReadOnly</b>: Does not connect to the primary instance and cannot accept write requests. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>DbEndpointOperator</b> is set to <b>Create</b>.</description></item>
        /// <item><description>For an ApsaraDB RDS for MySQL instance, if you change the value of this parameter from <b>ReadWrite</b> to <b>ReadOnly</b>, the transaction splitting feature is disabled.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWrite</para>
        /// </summary>
        [NameInMap("DbEndpointReadWriteMode")]
        [Validation(Required=false)]
        public string DbEndpointReadWriteMode { get; set; }

        /// <summary>
        /// <para>The type of the proxy endpoint. This parameter is reserved and does not need to be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RWSplit</para>
        /// </summary>
        [NameInMap("DbEndpointType")]
        [Validation(Required=false)]
        public string DbEndpointType { get; set; }

        /// <summary>
        /// <para>The specific time when the modification takes effect. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>EffectiveTime</b> is set to <b>SpecificTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-06T07:08:09Z</para>
        /// </summary>
        [NameInMap("EffectiveSpecificTime")]
        [Validation(Required=false)]
        public string EffectiveSpecificTime { get; set; }

        /// <summary>
        /// <para>The effective period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The modification immediately takes effect.</description></item>
        /// <item><description><b>MaintainTime</b>: The modification takes effect within the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>SpecificTime</b>: The modification takes effect at a specified time.</description></item>
        /// </list>
        /// <para>Default value: <b>MaintainTime</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The read weight allocation pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: Automatically allocates read weights based on instance specifications. This is the default value.</description></item>
        /// <item><description><b>Custom</b>: Custom allocated weights.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when read/write splitting is enabled. For more information about the read weight allocation pattern, see <a href="https://help.aliyun.com/document_detail/96076.html">Read weight distribution</a> for MySQL and <a href="https://help.aliyun.com/document_detail/418272.html">Enable and configure the database proxy service</a> for PostgreSQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceDistributionType")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceDistributionType { get; set; }

        /// <summary>
        /// <para>The maximum latency threshold for read-only instances in read/write splitting. If the latency of a read-only instance exceeds this threshold, read traffic is not routed to the instance. Unit: seconds. If you do not specify this parameter, the original value is retained. Valid values: <b>0</b> to <b>3600</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only when read/write splitting is enabled.</description></item>
        /// <item><description>Default value: <b>30</b> when the read/write attribute is set to Read/Write (read/write splitting), and <b>-1</b> (disabled) when the read/write attribute is set to Read-only.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceMaxDelayTime")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceMaxDelayTime { get; set; }

        /// <summary>
        /// <para>The custom read weights of the primary and read-only instances. The weight must be a multiple of 100 and cannot exceed 10000. Format:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard instance: <c>{&quot;Primary instance ID&quot;:&quot;Weight&quot;,&quot;Read-only instance ID&quot;:&quot;Weight&quot;...}</c></para>
        /// <para>  Example: <c>{&quot;rm-uf6wjk5****&quot;:&quot;500&quot;,&quot;rr-tfhfgk5xxx&quot;:&quot;200&quot;...}</c></para>
        /// </description></item>
        /// <item><description><para>ApsaraDB RDS for MySQL Cluster Edition instance: <c>{&quot;Read-only instance ID&quot;:&quot;Weight&quot;,&quot;DBClusterNode&quot;:{&quot;Primary node ID&quot;:&quot;Weight&quot;,&quot;Secondary node ID&quot;:&quot;Weight&quot;,&quot;Secondary node ID&quot;:&quot;Weight&quot;...}}</c></para>
        /// <para>  Example: <c>{&quot;rr-tfhfgk5****&quot;:&quot;200&quot;,&quot;DBClusterNode&quot;:{&quot;rn-2z****&quot;:&quot;0&quot;,&quot;rn-2z****&quot;:&quot;400&quot;,&quot;rn-2z****&quot;:&quot;400&quot;...}}</c></para>
        /// <remarks>
        /// <para><b>DBClusterNode</b> is a request parameter specific to Cluster Edition instances. It contains the <b>NodeID</b> and <b>Weight</b> of the primary and secondary nodes.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rm-uf6wjk5****&quot;:&quot;500&quot;,&quot;rr-tfhfgk5xxx&quot;:&quot;200&quot;...}</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceWeight")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceWeight { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the zone of the database proxy endpoint. Default value: the ID of the vSwitch that corresponds to the default endpoint of the proxy instance. You can call the DescribeVSwitches operation to query created vSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in the zone of the database proxy endpoint. Default value: the ID of the VPC that corresponds to the default endpoint of the proxy instance. You can call the DescribeDBInstanceAttribute operation to query the default VPC of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zeusejj******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
