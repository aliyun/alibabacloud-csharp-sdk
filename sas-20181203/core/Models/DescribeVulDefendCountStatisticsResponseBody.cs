// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulDefendCountStatisticsResponseBody : TeaModel {
        [NameInMap("RaspDefendedCount")]
        [Validation(Required=false)]
        public int? RaspDefendedCount { get; set; }

        [NameInMap("RaspDefensibleCount")]
        [Validation(Required=false)]
        public int? RaspDefensibleCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
