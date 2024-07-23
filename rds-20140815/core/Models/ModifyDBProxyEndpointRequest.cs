// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The features that you want to enable for the proxy endpoint. If you specify more than one feature, separate the features with semicolons (;). Format: <c>Feature 1:Status;Feature 2:Status;...</c>. Do not add a semicolon (;) at the end of the value.</para>
        /// <para>Valid feature values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWriteSpliting</b>: read/write splitting</description></item>
        /// <item><description><b>ConnectionPersist</b>: connection pooling</description></item>
        /// <item><description><b>TransactionReadSqlRouteOptimizeStatus</b>: transaction splitting</description></item>
        /// </list>
        /// <para>Valid status values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: disabled</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the instance runs PostgreSQL, you can enable only the read/write splitting feature, which is specified by <b>ReadWriteSpliting</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ReadWriteSpliting:1;ConnectionPersist:0</para>
        /// </summary>
        [NameInMap("ConfigDBProxyFeatures")]
        [Validation(Required=false)]
        public string ConfigDBProxyFeatures { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp145737x5bi6****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the proxy endpoint. You can call the DescribeDBProxyEndpoint operation to query the proxy endpoint ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the instance runs MySQL and you set <b>DbEndpointOperator</b> to <b>Delete</b> or <b>Modify</b>, you must specify DBProxyEndpointId.</description></item>
        /// <item><description>If the instance runs PostgreSQL and you set <b>DbEndpointOperator</b> to <b>Delete</b>, <b>Modify</b>, or <b>Create</b>, you must specify DBProxyEndpointId.</description></item>
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
        /// <para>A deprecated parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The description of the proxy terminal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-proxy</para>
        /// </summary>
        [NameInMap("DbEndpointAliases")]
        [Validation(Required=false)]
        public string DbEndpointAliases { get; set; }

        /// <summary>
        /// <para>The type of operation that you want to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Modify</b>: Modify a proxy terminal. This is the default value.</description></item>
        /// <item><description><b>Create</b>: Create a proxy terminal.</description></item>
        /// <item><description><b>Delete</b>: Delete a proxy terminal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Modify</para>
        /// </summary>
        [NameInMap("DbEndpointOperator")]
        [Validation(Required=false)]
        public string DbEndpointOperator { get; set; }

        /// <summary>
        /// <para>The read and write attributes of the proxy terminal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadWrite</b>: The proxy terminal connects to the primary instance and can receive both read and write requests.</description></item>
        /// <item><description><b>ReadOnly</b>: The proxy terminal does not connect to the primary instance and can receive only read requests. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>DbEndpointOperator</b> to <b>Create</b>, you must also specify DbEndpointReadWriteMode.</description></item>
        /// <item><description>If the instance runs MySQL and you change the value of this parameter from <b>ReadWrite</b> to <b>ReadOnly</b>, the transaction splitting feature is disabled.</description></item>
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
        /// <para>The type of the proxy terminal. This is a reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RWSplit</para>
        /// </summary>
        [NameInMap("DbEndpointType")]
        [Validation(Required=false)]
        public string DbEndpointType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The policy that is used to allocate read weights. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: The system automatically allocates read weights to the instance and its read-only instances based on the specifications of the instances.</description></item>
        /// <item><description><b>Custom</b>: You must manually allocate read weights to the instance and its read-only instances.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this parameter only when the read/write splitting feature is enabled. For more information about the permission allocation policy, see <a href="https://help.aliyun.com/document_detail/96076.html">Modify the latency threshold and read weights of ApsaraDB RDS for MySQL instances</a> and <a href="https://help.aliyun.com/document_detail/418272.html">Enable and configure the database proxy feature for an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceDistributionType")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceDistributionType { get; set; }

        /// <summary>
        /// <para>The latency threshold that is allowed for read/write splitting. If the latency on a read-only instance exceeds the threshold that you specified, the system no longer forwards read requests to the read-only instance. Unit: seconds If you do not specify this parameter, the original value of this parameter is retained. Valid values: <b>0</b> to <b>3600</b>. Default value: <b>30</b>.</para>
        /// <remarks>
        /// <para>You must specify this parameter only when the read/write splitting feature is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceMaxDelayTime")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceMaxDelayTime { get; set; }

        /// <summary>
        /// <para>The read weights of the instance and its read-only instances. A read weight must be a multiple of 100 and cannot exceed 10000. Formats:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard instance: <c>{&quot;ID of the primary instance&quot;:&quot;Weight&quot;,&quot;ID of the read-only instance&quot;:&quot;Weight&quot;...}</c></para>
        /// <para>Example: <c>{&quot;rm-uf6wjk5****&quot;:&quot;500&quot;,&quot;rr-tfhfgk5xxx&quot;:&quot;200&quot;...}</c></para>
        /// </description></item>
        /// <item><description><para>Instance on RDS Cluster Edition: <c>{&quot;ID of the read-only instance&quot;:&quot;Weight&quot;,&quot;DBClusterNode&quot;:{&quot;ID of the primary node&quot;:&quot;Weight&quot;,&quot;ID of the secondary node&quot;:&quot;Weight&quot;,&quot;ID of the secondary node&quot;:&quot;Weight&quot;...}}</c></para>
        /// <para>Example: <c>{&quot;rr-tfhfgk5****&quot;:&quot;200&quot;,&quot;DBClusterNode&quot;:{&quot;rn-2z****&quot;:&quot;0&quot;,&quot;rn-2z****&quot;:&quot;400&quot;,&quot;rn-2z****&quot;:&quot;400&quot;...}}</c></para>
        /// <remarks>
        /// <para><b>DBClusterNode</b> is required if the instance runs RDS Cluster Edition. The DBClusterNode parameter includes information about <b>IDs</b> and <b>weights</b> of the primary and secondary nodes..</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rm-uf6wjk5xxxx&quot;:&quot;500&quot;,&quot;rr-tfhfgk5xxx&quot;:&quot;200&quot;...}</para>
        /// </summary>
        [NameInMap("ReadOnlyInstanceWeight")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceWeight { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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

    }

}
