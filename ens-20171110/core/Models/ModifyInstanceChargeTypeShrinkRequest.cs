// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceChargeTypeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment when the billing method of the instance is changed from pay-as-you-go to subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables automatic payment. Make sure that your account balance is sufficient.</para>
        /// </description></item>
        /// <item><description><para>false: only generates the order without deducting the fee. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal when the billing method of the instance is changed from pay-as-you-go to subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para>false: disables auto-renewal. This is the default value.</para>
        /// </description></item>
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
        /// <para>Specifies whether to convert all pay-as-you-go data cloud disks created along with the instance into subscription data cloud disks when the billing method of the instance is changed from pay-as-you-go to subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: yes.</para>
        /// </description></item>
        /// <item><description><para>false: no. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDataDisks")]
        [Validation(Required=false)]
        public bool? IncludeDataDisks { get; set; }

        /// <summary>
        /// <para>The target billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PrePaid: converts the instance-level pay-as-you-go instance to a subscription instance.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: converts the subscription instance to an instance-level pay-as-you-go instance. This is the default value.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The subscription duration when the billing method of the instance is changed from pay-as-you-go to subscription. This parameter is required in this scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If PeriodUnit is set to Day, Period can only be set to 3.</para>
        /// </description></item>
        /// <item><description><para>If PeriodUnit is set to Month, Period can be set to 1, 2, 3, 4, 5, 6, 7, 8, 9, or 12.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration when the billing method of the instance is changed from pay-as-you-go to subscription. This parameter is required in this scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Month: month.</para>
        /// </description></item>
        /// <item><description><para>Day: day.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

    }

}
