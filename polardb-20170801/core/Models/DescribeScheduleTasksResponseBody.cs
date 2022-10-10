// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeScheduleTasksResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeScheduleTasksResponseBodyData Data { get; set; }
        public class DescribeScheduleTasksResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TimerInfos")]
            [Validation(Required=false)]
            public List<DescribeScheduleTasksResponseBodyDataTimerInfos> TimerInfos { get; set; }
            public class DescribeScheduleTasksResponseBodyDataTimerInfos : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("DbClusterDescription")]
                [Validation(Required=false)]
                public string DbClusterDescription { get; set; }

                [NameInMap("DbClusterStatus")]
                [Validation(Required=false)]
                public string DbClusterStatus { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("PlannedEndTime")]
                [Validation(Required=false)]
                public string PlannedEndTime { get; set; }

                [NameInMap("PlannedStartTime")]
                [Validation(Required=false)]
                public string PlannedStartTime { get; set; }

                [NameInMap("PlannedTime")]
                [Validation(Required=false)]
                public string PlannedTime { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskCancel")]
                [Validation(Required=false)]
                public bool? TaskCancel { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public int? TotalRecordCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
