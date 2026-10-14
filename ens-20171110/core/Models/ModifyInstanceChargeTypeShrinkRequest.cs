// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceChargeTypeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically complete the payment when you switch the billing method of the instance from pay-as-you-go to subscription. Valid values:</para>
        /// <para>true: The payment is automatically completed. Make sure that your account balance is sufficient.</para>
        /// <para>false: Only an order is generated but no payment is made. This is the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal when converting the instance from pay-as-you-go to subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Auto-renewal is enabled.</description></item>
        /// <item><description>false: Auto-renewal is not enabled (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The billing cycle. Valid values: Month, Day, and Hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert all pay-as-you-go data cloud disks created with the instance to subscription data cloud disks when converting an instance-level pay-as-you-go instance to a subscription instance. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDataDisks")]
        [Validation(Required=false)]
        public bool? IncludeDataDisks { get; set; }

        /// <summary>
        /// <para>The target billing method of the instance. Valid values:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The subscription duration when converting a pay-as-you-go instance to subscription. This parameter is required in this scenario. Valid values:</para>
        /// <para>If PeriodUnit is set to Day, Period can only be set to 3.</para>
        /// <para>If PeriodUnit is set to Month, Period can be set to 1-9 or 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration when converting an instance-level pay-as-you-go instance to a subscription instance. This parameter is required in this scenario. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

    }

}
