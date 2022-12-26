// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulTargetStatisticsResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TargetStats")]
        [Validation(Required=false)]
        public List<DescribeVulTargetStatisticsResponseBodyTargetStats> TargetStats { get; set; }
        public class DescribeVulTargetStatisticsResponseBodyTargetStats : TeaModel {
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeVulTargetStatisticsResponseBodyTargetStatsTargets> Targets { get; set; }
            public class DescribeVulTargetStatisticsResponseBodyTargetStatsTargets : TeaModel {
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public string Flag { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("UuidCount")]
            [Validation(Required=false)]
            public int? UuidCount { get; set; }

            [NameInMap("VulType")]
            [Validation(Required=false)]
            public string VulType { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
