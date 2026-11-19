// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceDiskTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. Make sure that your account has sufficient balance.
        /// &lt;props=&quot;china&quot;&gt;- <b>false</b>: disables automatic payment. You can manually pay for the order in the console. Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Expenses</b> &gt; <b>Expenses and Costs</b>. In the left-side navigation pane, choose <b>Orders</b> &gt; <b>My Orders</b>. On the <b>Orders</b> tab, find the target order and complete the payment.
        /// &lt;props=&quot;intl&quot;&gt;- <b>false</b>: disables automatic payment. You can manually pay for the order in the console. Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose <b>Expenses</b> &gt; <b>Expenses and Costs</b>. In the left-side navigation pane, click <b>Order Management</b>. On the <b>Orders</b> page, find the target order and complete the payment.</description></item>
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
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The additional parameter for business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“ActivityId&quot;:&quot;000000000&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

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
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1fa5efaa93****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The new disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_auto</b>: ESSD AutoPL cloud disk.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Prerequisite: The disk space of the instance must be at least 40 GB before you call this operation. If the disk space is insufficient, call ModifyDBInstanceSpec to expand the disk.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DbInstanceStorageType")]
        [Validation(Required=false)]
        public string DbInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The additional parameter.</para>
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

        /// <summary>
        /// <para>The provisioned performance (IOPS). Valid values: 0 to 50,000.</para>
        /// <remarks>
        /// <para>If DbInstanceStorageType is set to cloud_auto, this parameter is conditionally required and can be set to 0. If this parameter is not specified, the API returns InvalidParameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1960</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
