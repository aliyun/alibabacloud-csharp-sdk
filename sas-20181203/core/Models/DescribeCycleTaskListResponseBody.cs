// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCycleTaskListResponseBody : TeaModel {
        [NameInMap("CycleScheduleResponseList")]
        [Validation(Required=false)]
        public List<DescribeCycleTaskListResponseBodyCycleScheduleResponseList> CycleScheduleResponseList { get; set; }
        public class DescribeCycleTaskListResponseBodyCycleScheduleResponseList : TeaModel {
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            [NameInMap("FirstDateStr")]
            [Validation(Required=false)]
            public long? FirstDateStr { get; set; }

            [NameInMap("IntervalPeriod")]
            [Validation(Required=false)]
            public int? IntervalPeriod { get; set; }

            [NameInMap("LastTaskId")]
            [Validation(Required=false)]
            public string LastTaskId { get; set; }

            [NameInMap("NextStartTimeStr")]
            [Validation(Required=false)]
            public long? NextStartTimeStr { get; set; }

            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("TargetEndTime")]
            [Validation(Required=false)]
            public int? TargetEndTime { get; set; }

            [NameInMap("TargetStartTime")]
            [Validation(Required=false)]
            public int? TargetStartTime { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeCycleTaskListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeCycleTaskListResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
