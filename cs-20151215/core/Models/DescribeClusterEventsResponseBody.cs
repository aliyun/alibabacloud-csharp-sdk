// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterEventsResponseBody : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeClusterEventsResponseBodyEvents> Events { get; set; }
        public class DescribeClusterEventsResponseBodyEvents : TeaModel {
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public DescribeClusterEventsResponseBodyEventsData Data { get; set; }
            public class DescribeClusterEventsResponseBodyEventsData : TeaModel {
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }
            };

            [NameInMap("event_id")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClusterEventsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClusterEventsResponseBodyPageInfo : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

    }

}
