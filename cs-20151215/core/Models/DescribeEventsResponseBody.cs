// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEvents> Events { get; set; }
        public class DescribeEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// 事件ID
            /// </summary>
            [NameInMap("event_id")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// 事件类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 事件源
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// 事件
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// 事件开始事件
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// 集群ID
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// 事件描述
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public DescribeEventsResponseBodyEventsData Data { get; set; }
            public class DescribeEventsResponseBodyEventsData : TeaModel {
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }
            };

        }

        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeEventsResponseBodyPageInfo : TeaModel {
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

    }

}
