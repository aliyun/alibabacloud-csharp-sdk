// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyNodeSpecBatchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically align the primary node to the primary zone after operations such as configuration changes for a multi-zone instance. If you choose not to align the node, one primary/secondary switchover (transient connection) is prevented. Default value: true.</para>
        /// </summary>
        [NameInMap("AlignPrimaryZone")]
        [Validation(Required=false)]
        public bool? AlignPrimaryZone { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. Make sure that your account has sufficient balance.
        /// &lt;props=&quot;china&quot;&gt;- <b>false</b>: disables automatic payment. You can log on to the ApsaraDB for MongoDB console, choose <b>Expenses</b> &gt; <b>Expenses and Costs</b> in the upper-right corner, choose <b>Orders</b> &gt; <b>My Orders</b> in the left-side navigation pane, and then find the target order on the <b>Orders</b> tab to complete the payment.
        /// &lt;props=&quot;intl&quot;&gt;- <b>false</b>: disables automatic payment. You can log on to the ApsaraDB for MongoDB console, choose <b>Expenses</b> &gt; <b>Expenses and Costs</b> in the upper-right corner, click <b>Order Management</b> in the left-side navigation pane, and then find the target order on the <b>Orders</b> page to complete the payment.</description></item>
        /// </list>
        /// <para>Default value: <b>true</b>.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the token, but you must ensure that it is unique among different requests. The token can contain a maximum of 64 ASCII characters and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>The instance ID of the instance whose configurations you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1337621e8f****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The effective period of the configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The configuration change takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The configuration change takes effect during the maintenance window of the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can invoke the <a href="https://help.aliyun.com/document_detail/62008.html">ModifyDBInstanceMaintainTime</a> operation to modify the maintenance window of the instance.</description></item>
        /// <item><description>You can invoke the <a href="https://help.aliyun.com/document_detail/62010.html">DescribeDBInstanceAttribute</a> operation to view the maintenance window of the instance.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Default value: <b>Immediately</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The specifications of the Mongos or shard nodes to be modified. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Shards&quot;:[{&quot;DBInstanceClass&quot;:&quot;dds.shard.mid&quot;,&quot;DBInstanceName&quot;:&quot;d-bp14ae4572fd****&quot;,&quot;Storage&quot;:20},{&quot;DBInstanceClass&quot;:&quot;dds.shard.mid&quot;,&quot;DBInstanceName&quot;:&quot;d-bp19f4f92dc5****&quot;,&quot;Storage&quot;:30}]}</para>
        /// </summary>
        [NameInMap("NodesInfo")]
        [Validation(Required=false)]
        public string NodesInfo { get; set; }

        /// <summary>
        /// <para>The type of the configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b>: upgrades the configurations.</description></item>
        /// <item><description><b>DOWNGRADE</b>: downgrades the configurations.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when the billing method of the instance is subscription.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query available regions.</para>
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
        /// <para>The destination zone of the hidden node when you migrate the instance across zones and change its configurations at the same time.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice>
        /// Notice: The value of this parameter cannot be the same as the value of the TargetZoneId or TargetSecondaryZoneId parameter.</notice></para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you migrate the instance across zones and change its configurations at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("TargetHiddenZoneId")]
        [Validation(Required=false)]
        public string TargetHiddenZoneId { get; set; }

        /// <summary>
        /// <para>The destination zone of the secondary node when you migrate the instance across zones and change its configurations at the same time.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice>
        /// Notice: The value of this parameter cannot be the same as the value of the TargetZoneId or TargetHiddenZoneId parameter.</notice></para>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you migrate the instance across zones and change its configurations at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("TargetSecondaryZoneId")]
        [Validation(Required=false)]
        public string TargetSecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the destination vSwitch when you migrate the instance across zones and change its configurations at the same time.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice></para>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you migrate the instance across zones and change its configurations at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxxxxxx</para>
        /// </summary>
        [NameInMap("TargetVswitchId")]
        [Validation(Required=false)]
        public string TargetVswitchId { get; set; }

        /// <summary>
        /// <para>The destination zone of the primary node when you migrate the instance across zones and change its configurations at the same time.</para>
        /// <remarks>
        /// <para>Notice: This parameter is supported only for cloud disk instances.</notice>
        /// Notice: The value of this parameter cannot be the same as the value of the TargetSecondaryZoneId or TargetHiddenZoneId parameter.</notice></para>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you migrate the instance across zones and change its configurations at the same time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("TargetZoneId")]
        [Validation(Required=false)]
        public string TargetZoneId { get; set; }

    }

}
