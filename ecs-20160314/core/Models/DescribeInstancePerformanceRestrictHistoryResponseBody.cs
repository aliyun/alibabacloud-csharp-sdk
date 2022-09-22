// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeInstancePerformanceRestrictHistoryResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PerformanceRestrictHistories")]
        [Validation(Required=false)]
        public DescribeInstancePerformanceRestrictHistoryResponseBodyPerformanceRestrictHistories PerformanceRestrictHistories { get; set; }
        public class DescribeInstancePerformanceRestrictHistoryResponseBodyPerformanceRestrictHistories : TeaModel {
            [NameInMap("PerformanceRestrictHistory")]
            [Validation(Required=false)]
            public List<DescribeInstancePerformanceRestrictHistoryResponseBodyPerformanceRestrictHistoriesPerformanceRestrictHistory> PerformanceRestrictHistory { get; set; }
            public class DescribeInstancePerformanceRestrictHistoryResponseBodyPerformanceRestrictHistoriesPerformanceRestrictHistory : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Intervals")]
                [Validation(Required=false)]
                public DescribeInstancePerformanceRestrictHistoryResponseBodyPerformanceRestrictHistoriesPerformanceRestrictHistoryIntervals Intervals { get; set; }
                public class DescribeInstancePerformanceRestrictHistoryResponseBodyPerformanceRestrictHistoriesPerformanceRestrictHistoryIntervals : TeaModel {
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public List<string> Interval { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
