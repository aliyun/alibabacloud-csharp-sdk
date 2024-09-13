// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceChargeTypeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-payment when you change the billing method from pay-as-you-go to subscription. Valid values:
        /// 
        /// true: enables auto-payment. Make sure that your account has sufficient balance.
        /// 
        /// false (default): does not enable auto-payment. The order is generated but not paid.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal when you change the billing method from pay-as-you-go to subscription. Valid values:
        /// 
        /// true: enables auto-renewal for the instance.
        /// 
        /// false
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Specifies whether to change the billing method of all data disks that are created with the instance to subscription when you change the billing method of the instance from pay-as-you-go to subscription. Valid values:
        /// 
        /// true
        /// 
        /// false (default)
        /// </summary>
        [NameInMap("IncludeDataDisks")]
        [Validation(Required=false)]
        public bool? IncludeDataDisks { get; set; }

        /// <summary>
        /// The new billing method. Valid values:
        /// 
        /// PrePaid
        /// 
        /// PostPaid (default)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The IDs of the instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The subscription duration. This parameter is required if you set the InstanceChargeType parameter to PrePaid. Valid values:
        /// 
        /// If the PeriodUnit parameter is set to Day, Period can only be set to 3.
        /// 
        /// If PeriodUnit is Month, Period can be set to 1 to 9 or 12.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration. This parameter is required if you set the InstanceChargeType parameter to PrePaid. Valid values:
        /// 
        /// Month
        /// 
        /// Day
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

    }

}
