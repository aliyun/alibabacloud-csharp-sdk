// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n3a****</para>
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
        /// <para>The number of database proxies. If you set this parameter to 0, the database proxy feature is disabled for the instance. Valid values: <b>1</b> to <b>16</b>.</para>
        /// <remarks>
        /// <para> The capability of the database proxy feature to process requests increases with the number of database proxies that are enabled. You can monitor the load on the instance and specify an appropriate number of database proxies based on the load monitoring data.</para>
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
        /// <para>The database proxy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: general-purpose database proxy</description></item>
        /// <item><description><b>exclusive</b> (default): dedicated database proxy</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DedicatedProxy</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// <para>List of proxy nodes.</para>
        /// <remarks>
        /// <para>This parameter must be passed when the current proxy instance is deployed in multiple availability zones.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public List<ModifyDBProxyInstanceRequestDBProxyNodes> DBProxyNodes { get; set; }
        public class ModifyDBProxyInstanceRequestDBProxyNodes : TeaModel {
            /// <summary>
            /// <para>The number of cpu cores for the node, valid values: <b>1</b> to <b>16</b>.</para>
            /// <remarks>
            /// <para>This parameter is required when selecting <b>DBProxyNodes</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <para>The number of proxy nodes in the availability zone, valid values: <b>1</b> to <b>16</b>.</para>
            /// <remarks>
            /// <para>This parameter is required when selecting <b>DBProxyNodes</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeCounts")]
            [Validation(Required=false)]
            public string NodeCounts { get; set; }

            /// <summary>
            /// <para>The id of the availability zone where the node is located.</para>
            /// <remarks>
            /// <para>This parameter is required when selecting <b>DBProxyNodes</b>.</para>
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
        /// <para>The point in time that you want to specify. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> If the <b>EffectiveTime</b> parameter is set to <b>SpecificTime</b>, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-10T13:15:12Z</para>
        /// </summary>
        [NameInMap("EffectiveSpecificTime")]
        [Validation(Required=false)]
        public string EffectiveSpecificTime { get; set; }

        /// <summary>
        /// <para>The effective time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The effective time is immediate.</description></item>
        /// <item><description><b>MaintainTime</b>: The effective time is within the maintenance window. For more information, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>SpecificTime</b>: The effective time is a specified point in time.</description></item>
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
        /// <para>The list of available zones for migration agents.</para>
        /// <remarks>
        /// <para>Currently, only RDS MySQL cloud disk version agent instance migration is supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MigrateAZ")]
        [Validation(Required=false)]
        public List<ModifyDBProxyInstanceRequestMigrateAZ> MigrateAZ { get; set; }
        public class ModifyDBProxyInstanceRequestMigrateAZ : TeaModel {
            /// <summary>
            /// <para>The proxy connection address ID. You can obtain it through the DescribeDBProxyEndpoint interface.</para>
            /// <remarks>
            /// <para>This parameter is required when MigrateAZ is selected.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>yhw429********</para>
            /// </summary>
            [NameInMap("dbProxyEndpointId")]
            [Validation(Required=false)]
            public string DbProxyEndpointId { get; set; }

            /// <summary>
            /// <para>The target VSwitchId corresponding to the proxy instance migration.</para>
            /// <remarks>
            /// <para>This parameter is required when MigrateAZ is selected.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sw0qq49d1m****</para>
            /// </summary>
            [NameInMap("destVSwitchId")]
            [Validation(Required=false)]
            public string DestVSwitchId { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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

        /// <summary>
        /// <para>The ID of the vSwitch in the destination zone. You can call the <a href="https://help.aliyun.com/document_detail/610431.html">DescribeVSwitches</a> operation to query existing vSwitches.</para>
        /// <remarks>
        /// <para> Only database proxies for ApsaraDB RDS for MySQL instances that use cloud disks can be migrated to different zones.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

    }

}
