// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n3a****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>A deprecated parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The number of proxy instances. If this parameter is set to 0, the proxy service of this type is disabled for the instance. Valid values: <b>1</b> to <b>16</b>.</para>
        /// <remarks>
        /// <para>More proxy instances can handle more requests. You can check the load of proxy instances based on monitoring data and then specify an appropriate number of proxy instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public string DBProxyInstanceNum { get; set; }

        /// <summary>
        /// <para>The type of the database proxy instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: general-purpose database proxy</description></item>
        /// <item><description><b>exclusive</b>: dedicated database proxy (default)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exclusive</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// <para>The list of proxy nodes.</para>
        /// <remarks>
        /// <para>This parameter is required when the current proxy instance uses multi-active zone deployment.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public List<ModifyDBProxyInstanceRequestDBProxyNodes> DBProxyNodes { get; set; }
        public class ModifyDBProxyInstanceRequestDBProxyNodes : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores for the node. Valid values: <b>1</b> to <b>16</b>.</para>
            /// <remarks>
            /// <para>This parameter is required when <b>DBProxyNodes</b> is specified.</para>
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
            /// <para>This parameter is required when <b>DBProxyNodes</b> is specified.</para>
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
            /// <para>This parameter is required when <b>DBProxyNodes</b> is specified.</para>
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
        /// <para>The specified time for the modification to take effect. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>This parameter is required when <b>EffectiveTime</b> is set to <b>SpecificTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("EffectiveSpecificTime")]
        [Validation(Required=false)]
        public string EffectiveSpecificTime { get; set; }

        /// <summary>
        /// <para>The effective period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The modification takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The modification takes effect during the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
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

        /// <summary>
        /// <para>The list of active zones for proxy migration.</para>
        /// <remarks>
        /// <para>Currently, only ApsaraDB RDS for MySQL proxy instances with cloud disks support active zone migration.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MigrateAZ")]
        [Validation(Required=false)]
        public List<ModifyDBProxyInstanceRequestMigrateAZ> MigrateAZ { get; set; }
        public class ModifyDBProxyInstanceRequestMigrateAZ : TeaModel {
            /// <summary>
            /// <para>The proxy endpoint ID. You can call DescribeDBProxyEndpoint to obtain the proxy endpoint ID.</para>
            /// <remarks>
            /// <para>This parameter is required when <b>MigrateAZ</b> is specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>yhw429********</para>
            /// </summary>
            [NameInMap("dbProxyEndpointId")]
            [Validation(Required=false)]
            public string DbProxyEndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the destination vSwitch for the proxy instance migration.</para>
            /// <remarks>
            /// <para>This parameter is required when <b>MigrateAZ</b> is specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sw0qq49d1m****</para>
            /// </summary>
            [NameInMap("destVSwitchId")]
            [Validation(Required=false)]
            public string DestVSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the destination VPC for the proxy instance migration.</para>
            /// <remarks>
            /// <para>This parameter is required when <b>MigrateAZ</b> is specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vcicu73rdylp****</para>
            /// </summary>
            [NameInMap("destVpcId")]
            [Validation(Required=false)]
            public string DestVpcId { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to obtain the region ID.</para>
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
        /// <para>A deprecated parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

    }

}
