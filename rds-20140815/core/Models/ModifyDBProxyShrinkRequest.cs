// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable, disable, or modify the database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Startup</b>: Enables the database proxy.</description></item>
        /// <item><description><b>Shutdown</b>: Disables the database proxy.</description></item>
        /// <item><description><b>Modify</b>: Modifies the database proxy.</description></item>
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
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
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
        /// <para>The number of proxy instances. Valid values: <b>1</b> to <b>16</b>. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>More proxy instances can handle more requests. You can check the monitoring data to understand the load on proxy instances and then set an appropriate number of proxy instances.</para>
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
        /// <item><description><b>common</b>: general-purpose database proxy</description></item>
        /// <item><description><b>exclusive</b>: dedicated database proxy (default)</description></item>
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
        public string DBProxyNodesShrink { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Only Virtual Private Cloud (VPC) is supported. Set the value to <b>VPC</b>.</para>
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
        /// <para>Specifies whether to enable persistent connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enables persistent connections.</description></item>
        /// <item><description><b>Disabled</b>: disables persistent connections.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only RDS MySQL supports this parameter.</description></item>
        /// <item><description>To modify the persistent connection status, set <b>ConfigDBProxyService</b> to <b>Modify</b>.</description></item>
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
        /// <para>The region ID. You can call DescribeRegions to obtain the region ID.</para>
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
        /// <para>The VPC ID of the instance. You can call DescribeDBInstanceAttribute to obtain the VPC ID.</para>
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
        /// <para>The vSwitch ID of the instance. You can call DescribeDBInstanceAttribute to obtain the vSwitch ID.</para>
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
