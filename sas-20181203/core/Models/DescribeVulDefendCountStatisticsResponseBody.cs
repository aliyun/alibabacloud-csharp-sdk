// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDefendCountStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of defended vulnerabilities.
        /// </summary>
        [NameInMap("RaspDefendedCount")]
        [Validation(Required=false)]
        public int? RaspDefendedCount { get; set; }

        /// <summary>
        /// The number of supported vulnerabilities.
        /// </summary>
        [NameInMap("RaspDefensibleCount")]
        [Validation(Required=false)]
        public int? RaspDefensibleCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
