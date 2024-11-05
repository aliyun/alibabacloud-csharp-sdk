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
        /// <item><description><b>true</b>: enables automatic payment. Make sure that you have sufficient balance within your account.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. You must perform the following operations to pay for the instance: Log on to the ApsaraDB for MongoDB console. In the upper-right corner, click <b>Expenses</b> and select <b>User Center</b> from the drop-down list. The User Center page appears. In the left-side navigation pane, choose <b>Order Management</b> &gt; Renew. On the Renewal tab, find the bill that you want to pay and then click Renew in the Actions column.</description></item>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <para>The business information. This is an additional parameter.</para>
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
        /// <item><description><b>cloud_auto</b>: ESSD AutoPL disk</description></item>
        /// <item><description><b>cloud_essd1</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DbInstanceStorageType")]
        [Validation(Required=false)]
        public string DbInstanceStorageType { get; set; }

        /// <summary>
        /// <para>An additional parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The type of configuration changes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b></description></item>
        /// <item><description><b>DOWNGRADE</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is valid only when the billing method of the instance is subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The provisioned IOPS. Valid values: 0 to 50000.</para>
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
