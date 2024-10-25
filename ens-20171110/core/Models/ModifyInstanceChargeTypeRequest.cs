// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-payment when you change the billing method from pay-as-you-go to subscription. Valid values:</para>
        /// <para>true: enables auto-payment. Make sure that your account has sufficient balance.</para>
        /// <para>false (default): does not enable auto-payment. The order is generated but not paid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal when you change the billing method from pay-as-you-go to subscription. Valid values:</para>
        /// <para>true: enables auto-renewal for the instance.</para>
        /// <para>false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to change the billing method of all data disks that are created with the instance to subscription when you change the billing method of the instance from pay-as-you-go to subscription. Valid values:</para>
        /// <para>true</para>
        /// <para>false (default)</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDataDisks")]
        [Validation(Required=false)]
        public bool? IncludeDataDisks { get; set; }

        /// <summary>
        /// <para>The new billing method. Valid values:</para>
        /// <para>PrePaid</para>
        /// <para>PostPaid (default)</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of the instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter is required if you set the InstanceChargeType parameter to PrePaid. Valid values:</para>
        /// <para>If the PeriodUnit parameter is set to Day, Period can only be set to 3.</para>
        /// <para>If PeriodUnit is Month, Period can be set to 1 to 9 or 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is required if you set the InstanceChargeType parameter to PrePaid. Valid values:</para>
        /// <para>Month</para>
        /// <para>Day</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

    }

}
