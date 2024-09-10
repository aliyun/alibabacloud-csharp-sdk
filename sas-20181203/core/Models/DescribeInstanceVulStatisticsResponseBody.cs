// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceVulStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VulStat")]
        [Validation(Required=false)]
        public DescribeInstanceVulStatisticsResponseBodyVulStat VulStat { get; set; }
        public class DescribeInstanceVulStatisticsResponseBodyVulStat : TeaModel {
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public string AsapCount { get; set; }

            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public string LaterCount { get; set; }

            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public string NntfCount { get; set; }

        }

    }

}
