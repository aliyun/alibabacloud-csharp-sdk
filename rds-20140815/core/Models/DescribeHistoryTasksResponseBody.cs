// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryTasksResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksResponseBodyItems : TeaModel {
            [NameInMap("ActionInfo")]
            [Validation(Required=false)]
            public string ActionInfo { get; set; }

            [NameInMap("CallerSource")]
            [Validation(Required=false)]
            public string CallerSource { get; set; }

            [NameInMap("CallerUid")]
            [Validation(Required=false)]
            public string CallerUid { get; set; }

            [NameInMap("CurrentStepName")]
            [Validation(Required=false)]
            public string CurrentStepName { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TaskDetail")]
            [Validation(Required=false)]
            public string TaskDetail { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
