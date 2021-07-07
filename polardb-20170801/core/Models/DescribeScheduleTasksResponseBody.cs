// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeScheduleTasksResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScheduleTasksResponseBodyData Data { get; set; }
        public class DescribeScheduleTasksResponseBodyData : TeaModel {
            [NameInMap("TimerInfos")]
            [Validation(Required=false)]
            public List<DescribeScheduleTasksResponseBodyDataTimerInfos> TimerInfos { get; set; }
            public class DescribeScheduleTasksResponseBodyDataTimerInfos : TeaModel {
                public string Status { get; set; }
                public string Action { get; set; }
                public string PlannedEndTime { get; set; }
                public string PlannedTime { get; set; }
                public string DBClusterId { get; set; }
                public string Region { get; set; }
                public string PlannedStartTime { get; set; }
                public string TaskId { get; set; }
                public string OrderId { get; set; }
                public string DbClusterStatus { get; set; }
                public string DbClusterDescription { get; set; }
            }
            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public int? TotalRecordCount { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
