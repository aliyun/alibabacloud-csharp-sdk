// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable the database proxy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Startup</b>: enables the feature.</description></item>
        /// <item><description><b>Shutdown</b>: disables the feature.</description></item>
        /// <item><description><b>Modify</b>: modifies the configuration of the feature.</description></item>
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
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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
        /// <para>The number of proxy instances that are enabled. Valid values: <b>1</b> to <b>16</b>. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para> The capability of the database proxy to process requests increases with the number of proxy instances that are enabled. You can monitor the load on the instance and specify an appropriate number of proxy instances based on the load monitoring data.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public string DBProxyInstanceNum { get; set; }

        /// <summary>
        /// <para>The database proxy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: general-purpose database proxy</description></item>
        /// <item><description><b>exclusive</b> (default): dedicated database proxy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// <para>The proxy nodes.</para>
        /// </summary>
        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public List<ModifyDBProxyRequestDBProxyNodes> DBProxyNodes { get; set; }
        public class ModifyDBProxyRequestDBProxyNodes : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores of the node. Valid values: <b>1</b> to <b>16</b>.</para>
            /// <remarks>
            /// <para> This parameter is required when you configure the <b>DBProxyNodes</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <para>The number of proxy nodes in the zone. Valid values: <b>1</b> and <b>2</b>.</para>
            /// <remarks>
            /// <para> This parameter is required when you configure the <b>DBProxyNodes</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeCounts")]
            [Validation(Required=false)]
            public string NodeCounts { get; set; }

            /// <summary>
            /// <para>The ID of the zone in which the node resides.</para>
            /// <remarks>
            /// <para> This parameter is required when you configure the <b>DBProxyNodes</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hagnzhou-c</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The network type of the instance. Only the VPC network type is supported. Set the value to <b>VPC</b>.</para>
        /// <remarks>
        /// <para> If you enable the database proxy feature for the instance, you must specify this parameter.</para>
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
        /// <para>Specifies whether to enable persistent connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available only for instances that run MySQL.</para>
        /// </description></item>
        /// <item><description><para>If you want to modify persistent connections, you must set the <b>ConfigDBProxyService</b> parameter to <b>Modify</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("PersistentConnectionStatus")]
        [Validation(Required=false)]
        public string PersistentConnectionStatus { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>rg-acfmy*****</para>
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
        /// <para>The ID of the virtual private cloud (VPC) to which the instance belongs. You can call the DescribeDBInstanceAttribute operation to query the ID.</para>
        /// <remarks>
        /// <para> If you enable the database proxy feature for the instance, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the instance belongs. You can call the DescribeDBInstanceAttribute operation to query the ID.</para>
        /// <remarks>
        /// <para> If you enable the database proxy feature for the instance, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
