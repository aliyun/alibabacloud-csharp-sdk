// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthLimitationResponseBody : TeaModel {
        /// <summary>
        /// Details about the maximum public bandwidth.
        /// </summary>
        [NameInMap("Bandwidths")]
        [Validation(Required=false)]
        public DescribeBandwidthLimitationResponseBodyBandwidths Bandwidths { get; set; }
        public class DescribeBandwidthLimitationResponseBodyBandwidths : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public List<DescribeBandwidthLimitationResponseBodyBandwidthsBandwidth> Bandwidth { get; set; }
            public class DescribeBandwidthLimitationResponseBodyBandwidthsBandwidth : TeaModel {
                /// <summary>
                /// The billing method for network usage. Valid values:
                /// 
                /// *   PayByBandwidth
                /// *   PayByTraffic
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The maximum public bandwidth.
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// The minimum public bandwidth.
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// The unit of the public bandwidth.
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
