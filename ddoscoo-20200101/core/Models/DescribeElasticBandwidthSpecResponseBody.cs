// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeElasticBandwidthSpecResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the available burstable protection bandwidths. Unit: Gbit/s.
        /// </summary>
        [NameInMap("ElasticBandwidthSpec")]
        [Validation(Required=false)]
        public List<string> ElasticBandwidthSpec { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
