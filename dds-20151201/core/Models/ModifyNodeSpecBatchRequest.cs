// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyNodeSpecBatchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. Make sure that you have sufficient balance within your account.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. You can perform the following operations to pay for the instance: Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, click <b>Expenses</b> to go to the <b>Billing Management</b> console. In the left-side navigation pane, click <b>Orders</b>. On the <b>Orders</b> page, find the order and complete the payment.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The coupon code. Default value: <c>youhuiquan_promotion_option_id_for_blank</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// <para>The ID of the instance whose configurations you want to change.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1337621e8f****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The time when the changed configurations take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The configurations immediately take effect.</description></item>
        /// <item><description><b>MaintainTime</b>: The configurations take effect during the maintenance window of the instance.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/62008.html">ModifyDBInstanceMaintainTime</a> operation to modify the maintenance window of an instance.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/62010.html">DescribeDBInstanceAttribute</a> operation to view the maintenance window of an instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>Immediately</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The configuration information of the mongos nodes or shard nodes whose configurations you want to change. For more information, see <a href="https://help.aliyun.com/document_detail/57141.html">Instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Shards&quot;:[{&quot;DBInstanceClass&quot;:&quot;dds.shard.mid&quot;,&quot;DBInstanceName&quot;:&quot;d-bp14ae4572fd****&quot;,&quot;Storage&quot;:20},{&quot;DBInstanceClass&quot;:&quot;dds.shard.mid&quot;,&quot;DBInstanceName&quot;:&quot;d-bp19f4f92dc5****&quot;,&quot;Storage&quot;:30}]}</para>
        /// </summary>
        [NameInMap("NodesInfo")]
        [Validation(Required=false)]
        public string NodesInfo { get; set; }

        /// <summary>
        /// <para>The type of configuration changes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b></description></item>
        /// <item><description><b>DOWNGRADE</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is only applicable to instances whose billing method is subscription.</para>
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
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

    }

}
