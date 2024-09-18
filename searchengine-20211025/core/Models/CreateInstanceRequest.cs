// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// The billing method of the instance. Valid values: PREPAY: subscription. If you set this parameter to PREPAY, make sure that your Alibaba Cloud account supports balance payment or credit card payment. Otherwise, the system returns the InvalidPayMethod error message. If you set this parameter to PREPAY, you must also specify paymentInfo. POSTPAY: pay-as-you-go. This billing method is not supported.
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The information about the instance specification.
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestComponents> Components { get; set; }
        public class CreateInstanceRequestComponents : TeaModel {
            /// <summary>
            /// The code of the specification, which must be consistent with the value that you specify on the buy page.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The value of the specification.
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

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTags> Tags { get; set; }
        public class CreateInstanceRequestTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
