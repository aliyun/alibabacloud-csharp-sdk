// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. Make sure that your account has a sufficient balance. This is the default value.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: disables automatic payment. You can log on to the ApsaraDB for MongoDB console to pay for the instance. In the upper-right corner of the page, choose <b>Billing Management</b> &gt; <b>Billing Management</b>. In the left-side navigation pane, choose <b>Orders</b> &gt; <b>My Orders</b>. On the <b>Product Orders</b> tab, find the order and complete the payment.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: disables automatic payment. You can log on to the ApsaraDB for MongoDB console to pay for the instance. In the upper-right corner of the page, choose <b>Billing Management</b> &gt; <b>Billing Management</b>. In the left-side navigation pane, click <b>Orders</b>. On the <b>Product Orders</b> page, find the order and complete the payment.</description></item>
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
        /// <item><description><para><b>default</b> or <b>null</b> (default): A coupon is used.</para>
        /// </description></item>
        /// <item><description><para><b>youhuiquan_promotion_option_id_for_blank</b>: No coupon is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The instance type. &lt;props=&quot;intl&quot;&gt;For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>. You can also call the <a href="https://help.aliyun.com/document_detail/149719.html">DescribeAvailableResource</a> operation to query instance types.&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>For a standalone instance or a replica set instance, this parameter specifies the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>. You can also call the <a href="https://help.aliyun.com/document_detail/149719.html">DescribeAvailableResource</a> operation to query the instance types of standalone and replica set instances.</para>
        /// </description></item>
        /// <item><description><para>For a serverless instance, this parameter specifies the computing capacity of the instance. Valid values: 100 to 8000.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must configure one of the <b>DBInstanceStorage</b> and DBInstanceClass parameters.</para>
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
        /// <para>The storage capacity of the instance. &lt;props=&quot;intl&quot;&gt;The value must be an integer that is greater than or equal to 10. The value increases in increments of 10. Unit: GB. The values that can be specified for this parameter are subject to the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><para>The storage capacity of a standalone instance or a replica set instance must be a multiple of 10. The valid values are 10 to 3000. Unit: GB. The values that can be specified for this parameter are subject to the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// </description></item>
        /// <item><description><para>The storage capacity of a serverless instance must be a multiple of 1. The valid values are 1 to 100. Unit: GB.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must configure one of the <b>DBInstanceClass</b> and DBInstanceStorage parameters.</para>
        /// </description></item>
        /// <item><description><para>You cannot decrease the storage capacity of an instance.</para>
        /// </description></item>
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
        /// <para>The effective time of the configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Immediately</b>: The configuration change immediately takes effect. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>MaintainTime</b>: The configuration change takes effect during the maintenance window of the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>Additional parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>async</b>: The result is returned after the specification change order is created.</para>
        /// </description></item>
        /// <item><description><para><b>sync</b>: The result is returned after the instance specification change is delivered.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The specification change type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UPGRADE</b>: upgrades the specifications. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>DOWNGRADE</b>: downgrades the specifications.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only for subscription instances.</para>
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
        /// <para>If the network type of the instance is set to only <b>classic network</b> and <b>VPC</b>, you need to enable public access or release the classic network endpoint before you can change the <b>number of read-only nodes</b>.</para>
        /// <remarks>
        /// <para>You can log on to the ApsaraDB for MongoDB console and go to the <b>Database Connections</b> page to view the network types that have been enabled.</para>
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
        /// <item><description><para>Valid values for replica set instances: <b>3</b>, <b>5</b>, and <b>7</b>.</para>
        /// </description></item>
        /// <item><description><para>The value for standalone instances is fixed at <b>1</b>.</para>
        /// </description></item>
        /// <item><description><para>The value for replica set instances with shared storage (available only in the China site) is fixed at <b>2</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required for serverless instances (available only in the China site).</para>
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
        /// <para>The specifications of the Search node to be changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mdb.shard.2x.xlarge.d</para>
        /// </summary>
        [NameInMap("SearchNodeClass")]
        [Validation(Required=false)]
        public string SearchNodeClass { get; set; }

        /// <summary>
        /// <para>The number of Search nodes to be changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SearchNodeCount")]
        [Validation(Required=false)]
        public long? SearchNodeCount { get; set; }

        /// <summary>
        /// <para>The capacity of the Search node to be changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SearchNodeStorage")]
        [Validation(Required=false)]
        public long? SearchNodeStorage { get; set; }

        /// <summary>
        /// <para>The destination zone for the hidden node when you change the specifications and migrate the instance across zones.</para>
        /// <remarks>
        /// <para>Notice: This parameter applies only to cloud disk instances.
        /// Notice: The value of this parameter cannot be the same as the value of the TargetZoneId or TargetSecondaryZoneId parameter.</para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter only when you change the specifications and migrate the instance across zones.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only for multi-zone migration.</para>
        /// </description></item>
        /// <item><description><para>The destination zone and the current zone must be in the same region.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query zone IDs.</para>
        /// </description></item>
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
        /// <para>The destination secondary zone for the secondary node when you change the specifications and migrate the instance across zones.</para>
        /// <remarks>
        /// <para>Notice: This parameter applies only to cloud disk instances.
        /// Notice: The value of this parameter cannot be the same as the value of the TargetZoneId or TargetHiddenZoneId parameter.</para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter only when you change the specifications and migrate the instance across zones.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only for multi-zone migration.</para>
        /// </description></item>
        /// <item><description><para>The destination zone and the current zone must be in the same region.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query zone IDs.</para>
        /// </description></item>
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
        /// <para>The destination vSwitch ID when you change the specifications and migrate the instance across zones.</para>
        /// <remarks>
        /// <para>Notice: This parameter applies only to cloud disk instances.</para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter only when you change the specifications and migrate the instance across zones.</description></item>
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
        /// <para>The destination zone to which you want to migrate the instance when you change the specifications and migrate the instance across zones.</para>
        /// <remarks>
        /// <para>Notice: This parameter applies only to cloud disk instances.
        /// Notice: The value of this parameter cannot be the same as the value of the TargetSecondaryZoneId or TargetHiddenZoneId parameter.</para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter only when you change the specifications and migrate the instance across zones.</para>
        /// </description></item>
        /// <item><description><para>The destination zone and the current zone must be in the same region.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query zone IDs.</para>
        /// </description></item>
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
