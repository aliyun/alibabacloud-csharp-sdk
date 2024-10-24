// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable the database proxy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Startup</b>: enables the database proxy feature.</description></item>
        /// <item><description><b>Shutdown</b>: disables the database proxy feature.</description></item>
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
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
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
        /// <para>This parameter is reserved. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public string DBProxyNodesShrink { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Set the value to <b>VPC</b>.</para>
        /// <remarks>
        /// <para>This parameter is required if you enable the database proxy feature for an ApsaraDB RDS for MySQL instance that uses cloud disks or an ApsaraDB RDS for PostgreSQL instance.</para>
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
        /// <para>Whether to enable connection keep. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: enables connection keeping</description></item>
        /// <item><description>Disabled: disables connection hold</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is supported only for an ApsaraDB RDS for MySQL.</description></item>
        /// <item><description>When you modify the connection persistence state, the value of <b>ConfigDBProxyService</b> is modify.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The ID of the virtual private cloud (VPC) to which the instance belongs. You can call the DescribeDBInstanceAttribute operation to query the VPC ID.</para>
        /// <remarks>
        /// <para> This parameter is required if you enable the database proxy feature for an ApsaraDB RDS for MySQL instance that uses cloud disks or an ApsaraDB RDS for PostgreSQL instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the instance. You can call the DescribeDBInstanceAttribute operation to query the vSwitch ID.</para>
        /// <remarks>
        /// <para> This parameter is required if you enable the database proxy feature for an ApsaraDB RDS for MySQL instance that uses cloud disks or an ApsaraDB RDS for PostgreSQL instance.</para>
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
