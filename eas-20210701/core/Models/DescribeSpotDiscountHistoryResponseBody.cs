// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeSpotDiscountHistoryResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The discount for the preemptible instance.
        /// </summary>
        [NameInMap("SpotDiscounts")]
        [Validation(Required=false)]
        public List<DescribeSpotDiscountHistoryResponseBodySpotDiscounts> SpotDiscounts { get; set; }
        public class DescribeSpotDiscountHistoryResponseBodySpotDiscounts : TeaModel {
            /// <summary>
            /// The type of the ECS instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The discount for the preemptible instance. For example, 0.1 represents a 90% discount.
            /// </summary>
            [NameInMap("SpotDiscount")]
            [Validation(Required=false)]
            public string SpotDiscount { get; set; }

            /// <summary>
            /// The time when the discount is available. The time must be in UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// The zone ID.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
