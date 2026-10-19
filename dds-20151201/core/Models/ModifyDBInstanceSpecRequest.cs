// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically align the primary node to the primary zone for a multi-zone instance after operations such as configuration changes. If you choose not to align the node, one primary/secondary switchover (transient disconnection) is avoided. Default value: true (aligned).</para>
        /// </summary>
        [NameInMap("AlignPrimaryZone")]
        [Validation(Required=false)]
        public bool? AlignPrimaryZone { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. This is the default value. Make sure that your account has sufficient balance.
        /// &lt;props=&quot;china&quot;&gt;- <b>false</b>: disables automatic payment. You must manually pay for the order in the console. Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Expenses</b> &gt; <b>Expenses and Costs</b>. In the left-side navigation pane, choose <b>Orders</b> &gt; <b>My Orders</b>. On the <b>Orders</b> tab, find the order and complete the payment.
        /// &lt;props=&quot;intl&quot;&gt;- <b>false</b>: disables automatic payment. You must manually pay for the order in the console. Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Expenses</b> &gt; <b>Expenses and Costs</b>. In the left-side navigation pane, click <b>Order Management</b>. On the <b>Orders</b> page, find the order and complete the payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b> or <b>null</b>: uses a coupon. This is the default value.</description></item>
        /// <item><description><b>youhuiquan_promotion_option_id_for_blank</b>: does not use a coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance type. &lt;props=&quot;intl&quot;&gt;<ph>For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>. You can also call the <a href="https://help.aliyun.com/document_detail/149719.html">DescribeAvailableResource</a> operation to query instance types.</ph>
        /// &lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>For standalone instances and replica set instances, this parameter specifies the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>. You can also call the <a href="https://help.aliyun.com/document_detail/149719.html">DescribeAvailableResource</a> operation to query the instance types of standalone instances and replica set instances.</description></item>
        /// <item><description>For serverless instances, this parameter specifies the compute specifications of the instance. Valid values: 100 to 8000.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify at least one of the <b>DBInstanceClass</b> and <b>DBInstanceStorage</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds.sn4.xlarge.1</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1ea17b41ab****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Instance storage space of the instance. &lt;props=&quot;intl&quot;&gt;<ph>Valid values: 10 to 3000. Unit: GB. The step size is 10 GB. The valid values are subject to the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</ph></para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>For standalone instances and replica set instances, valid values are 10 to 3000. Unit: GB. The step size is 10 GB. The valid values are subject to the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</description></item>
        /// <item><description>For serverless instances, valid values are 1 to 100. Unit: GB. The step size is 1 GB.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of the <b>DBInstanceStorage</b> and <b>DBInstanceClass</b> parameters.</description></item>
        /// <item><description>You cannot downgrade instance storage space.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public string DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The time when the configuration change takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: takes effect immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: takes effect during the maintenance window of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The additional parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>async</b>: returns the result after the configuration change order is created.</description></item>
        /// <item><description><b>sync</b>: returns the result when the configuration change is delivered after the order is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The type of configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b>: upgrades the configurations. This is the default value.</description></item>
        /// <item><description><b>DOWNGRADE</b>: downgrades the configurations.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify this parameter only when the instance uses the subscription billing method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of read-only nodes. Valid values: <b>0</b> to <b>5</b>.</para>
        /// <para>If the instance is connected only over the <b>classic network</b> and a <b>VPC</b>, you must enable Internet access or release the classic network before you can change the <b>number of read-only nodes</b>.</para>
        /// <remarks>
        /// <para>You can log on to the ApsaraDB for MongoDB console and view the enabled network types on the <b>Database Connections</b> page.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// <para>The number of nodes in the instance. Default value: 3.</para>
        /// <list type="bullet">
        /// <item><description>For a replica set instance, valid values are <b>3</b>, <b>5</b>, and <b>7</b>.</description></item>
        /// <item><description>For a standalone instance, the value is fixed to <b>1</b>.</description></item>
        /// <item><description>For a replica set instance that uses shared storage (supported only on the Alibaba Cloud China site), the value is fixed to <b>2</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You do not need to specify this parameter for a serverless instance (supported only on the Alibaba Cloud China site).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The specifications of the search node for the configuration change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mdb.shard.2x.xlarge.d</para>
        /// </summary>
        [NameInMap("SearchNodeClass")]
        [Validation(Required=false)]
        public string SearchNodeClass { get; set; }

        /// <summary>
        /// <para>The number of search nodes for the configuration change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SearchNodeCount")]
        [Validation(Required=false)]
        public long? SearchNodeCount { get; set; }

        /// <summary>
        /// <para>The storage capacity of the search node for the configuration change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SearchNodeStorage")]
        [Validation(Required=false)]
        public long? SearchNodeStorage { get; set; }

        /// <summary>
        /// <para>The destination zone for the hidden node when you cloud disk instance across zones and change its configurations at the same time.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for instances that use cloud disks.</notice>
        /// Notice: The value of this parameter cannot be the same as the value of the TargetZoneId or TargetSecondaryZoneId parameter.</notice></para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you cloud disk instance across zones and change its configurations at the same time.</description></item>
        /// <item><description>This parameter is available only for multi-zone migration.</description></item>
        /// <item><description>The destination zone and the current zone of the instance must be in the same region.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query zone IDs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("TargetHiddenZoneId")]
        [Validation(Required=false)]
        public string TargetHiddenZoneId { get; set; }

        /// <summary>
        /// <para>The destination zone for the secondary node when you cloud disk instance across zones and change its configurations at the same time.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for instances that use cloud disks.</notice>
        /// Notice: The value of this parameter cannot be the same as the value of the TargetZoneId or TargetHiddenZoneId parameter.</notice></para>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you cloud disk instance across zones and change its configurations at the same time.</description></item>
        /// <item><description>This parameter is available only for multi-zone migration.</description></item>
        /// <item><description>The destination zone and the current zone of the instance must be in the same region.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query zone IDs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("TargetSecondaryZoneId")]
        [Validation(Required=false)]
        public string TargetSecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the destination vSwitch when you cloud disk instance across zones and change its configurations at the same time.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for instances that use cloud disks.</notice></para>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you cloud disk instance across zones and change its configurations at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1buy0h9myt5i9e7****</para>
        /// </summary>
        [NameInMap("TargetVswitchId")]
        [Validation(Required=false)]
        public string TargetVswitchId { get; set; }

        /// <summary>
        /// <para>The destination zone for instance migration when you migrate the instance across zones and change its configurations at the same time.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice>
        /// Notice: The value of this parameter cannot be the same as the value of the TargetSecondaryZoneId or TargetHiddenZoneId parameter.</notice></para>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you migrate the instance across zones and change its configurations at the same time.</description></item>
        /// <item><description>The destination zone and the current zone of the instance must be in the same region.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query zone IDs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("TargetZoneId")]
        [Validation(Required=false)]
        public string TargetZoneId { get; set; }

    }

}
