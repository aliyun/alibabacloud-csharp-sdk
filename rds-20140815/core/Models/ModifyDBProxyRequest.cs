// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable the database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Startup</b>: Enables the proxy service.</description></item>
        /// <item><description><b>Shutdown</b>: Disables the proxy service.</description></item>
        /// <item><description><b>Modify</b>: Modifies the proxy service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Startup</para>
        /// </summary>
        [NameInMap("ConfigDBProxyService")]
        [Validation(Required=false)]
        public string ConfigDBProxyService { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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
        /// <para>The number of proxy instances to enable. Valid values: <b>1</b> to <b>16</b>. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>More proxy instances can process more requests. You can check the load of proxy instances based on monitoring data and specify an appropriate number of proxy instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public string DBProxyInstanceNum { get; set; }

        /// <summary>
        /// <para>The type of the database proxy instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: General-purpose database proxy.</description></item>
        /// <item><description><b>exclusive</b>: Dedicated proxy (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exclusive</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// <para>The list of proxy nodes.</para>
        /// </summary>
        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public List<ModifyDBProxyRequestDBProxyNodes> DBProxyNodes { get; set; }
        public class ModifyDBProxyRequestDBProxyNodes : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores for the node. Valid values: <b>1</b> to <b>16</b>.</para>
            /// <remarks>
            /// <para>This parameter is required when you specify <b>DBProxyNodes</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <para>The number of proxy nodes in the zone. Valid values: <b>1</b> to <b>2</b>.</para>
            /// <remarks>
            /// <para>This parameter is required when you specify <b>DBProxyNodes</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeCounts")]
            [Validation(Required=false)]
            public string NodeCounts { get; set; }

            /// <summary>
            /// <para>The zone ID of the node.</para>
            /// <remarks>
            /// <para>This parameter is required when you specify <b>DBProxyNodes</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-c</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The network type of the instance. Only VPC is supported. Valid value: <b>VPC</b>.</para>
        /// <remarks>
        /// <para>This parameter is required when you enable the database proxy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable connection keep-alive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enables connection keep-alive.</description></item>
        /// <item><description><b>Disabled</b>: Disables connection keep-alive.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only ApsaraDB RDS for MySQL supports this parameter.</description></item>
        /// <item><description>When you modify the connection keep-alive status, set <b>ConfigDBProxyService</b> to <b>Modify</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("PersistentConnectionStatus")]
        [Validation(Required=false)]
        public string PersistentConnectionStatus { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the instance belongs. You can call the DescribeDBInstanceAttribute operation to query the VPC ID.</para>
        /// <remarks>
        /// <para>This parameter is required when you enable the database proxy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the instance belongs. You can call the DescribeDBInstanceAttribute operation to query the vSwitch ID.</para>
        /// <remarks>
        /// <para>This parameter is required when you enable the database proxy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
