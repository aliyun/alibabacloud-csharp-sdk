// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// The billing method of the instance. Valid values: PREPAY and POSTPAY. PREPAY indicates the instance is a subscription instance. When you set this parameter to PREPAY, make sure that your Alibaba Cloud account supports balance payment or credit card payment. Otherwise, the system returns the InvalidPayMethod error message. If you set this parameter to PREPAY, you must also specify the paymentInfo parameter. POSTPAY indicates that the instance is a pay-as-you-go instance. This billing method is not supported.
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// A list of instance-related specifications.
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestComponents> Components { get; set; }
        public class CreateInstanceRequestComponents : TeaModel {
            /// <summary>
            /// The specification code, which must be consistent with values of the corresponding module parameters.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// Values that you specify for the corresponding module components on the buy page.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The billing information.
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public CreateInstanceRequestOrder Order { get; set; }
        public class CreateInstanceRequestOrder : TeaModel {
            /// <summary>
            /// Specifies whether to enable auto-renewal. Valid values: true and false.
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// The billing duration. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, and 12.
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// The unit of the billing duration. Valid values: Month and Year.
            /// </summary>
            [NameInMap("pricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

        }

    }

}
