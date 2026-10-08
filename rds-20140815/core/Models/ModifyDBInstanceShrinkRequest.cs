// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Automatically uses coupons.</description></item>
        /// <item><description><b>false</b>: Does not automatically use coupons.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After a coupon is used, the amount deducted by the coupon is not refunded if you downgrade the instance specifications.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2340501.html">I/O burst feature for premium performance disks</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: High-availability Edition</description></item>
        /// <item><description><b>cluster</b>: Cluster Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2701832.html">cold data archiving feature</a> for general-purpose cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>&lt;props=&quot;china&quot;&gt;<b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para>&lt;props=&quot;china&quot;&gt;<b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ColdDataEnabled")]
        [Validation(Required=false)]
        public bool? ColdDataEnabled { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg.n4.2c.1m</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp15i4hn07r******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/26312.html">target storage capacity</a>, in GB. You can call the <a href="https://help.aliyun.com/document_detail/610393.html">DescribeAvailableClasses</a> operation to query the available storage capacity range for the target instance type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of this parameter and the <b>DBInstanceClass</b> parameter.</description></item>
        /// <item><description>You can call <a href="https://help.aliyun.com/document_detail/610394.html">DescribeDBInstanceAttribute</a> to query the current storage capacity of the instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>general_essd</b>: premium performance disk (recommended)</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The node information.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public string DBNodesShrink { get; set; }

        /// <summary>
        /// <para>The type of specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Up</b> (default): Upgrades a subscription instance or upgrades/downgrades a pay-as-you-go instance.</description></item>
        /// <item><description><b>Down</b>: Downgrades a subscription instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The time when the new configurations take effect. Valid values:</para>
        /// <remarks>
        /// <para><b>Changing some configurations may affect the instance</b>. Read the impact section in the <a href="https://help.aliyun.com/document_detail/96061.html">feature documentation</a> before you configure this parameter. Perform the operation during off-peak hours.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b> (default): The new configurations take effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The new configurations take effect during the <a href="https://help.aliyun.com/document_detail/610402.html">maintenance window</a>.</description></item>
        /// <item><description><b>ScheduleTime</b>: The new configurations take effect at a specified time. The specified time must be at least 12 hours later than the current time. The actual switchover time follows the formula: EffectiveTime = ScheduleTime + SwitchTime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE) feature</a> for premium performance disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The parameter template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-dp****</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The parameters and their values. All parameter values are of the STRING type. You can call DescribeParameterTemplates to query parameter names and values.</para>
        /// <remarks>
        /// <para>If you specify the <b>ParameterGroupId</b> parameter and both the ParameterGroupId and Parameters parameters modify the same parameter, the modification specified by the Parameters parameter takes precedence.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliwood-1688-mobile-promotion</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
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
        /// <para>The scheduled time for executing the parameter modification. The EffectiveTime parameter must be set to ScheduleTime. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The specified time must be later than the current time (the time when the call is made).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-17T18:50:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/126002.html">minor engine version</a> of the PostgreSQL instance. If the specification change fails because the current minor engine version is not supported, specify the minor engine version to <b>upgrade the minor engine version during the specification change</b>.</para>
        /// <para>Format: <c>rds_postgres_&lt;major version&gt;00_&lt;minor version&gt;</c>. Example for version 12 with minor version 20200830: <c>rds_postgres_1200_20200830</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_postgres_1200_20200830</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

    }

}
