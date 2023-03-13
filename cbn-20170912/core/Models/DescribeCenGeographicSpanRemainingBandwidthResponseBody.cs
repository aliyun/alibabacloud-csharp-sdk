// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenGeographicSpanRemainingBandwidthResponseBody : TeaModel {
        /// <summary>
        /// The remaining bandwidth of the bandwidth plan. Unit: Mbit/s.
        /// </summary>
        [NameInMap("RemainingBandwidth")]
        [Validation(Required=false)]
        public long? RemainingBandwidth { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
