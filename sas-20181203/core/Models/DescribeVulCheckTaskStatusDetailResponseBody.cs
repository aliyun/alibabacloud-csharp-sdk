// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulCheckTaskStatusDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskStatuses")]
        [Validation(Required=false)]
        public List<DescribeVulCheckTaskStatusDetailResponseBodyTaskStatuses> TaskStatuses { get; set; }
        public class DescribeVulCheckTaskStatusDetailResponseBodyTaskStatuses : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStatusList")]
            [Validation(Required=false)]
            public List<DescribeVulCheckTaskStatusDetailResponseBodyTaskStatusesTaskStatusList> TaskStatusList { get; set; }
            public class DescribeVulCheckTaskStatusDetailResponseBodyTaskStatusesTaskStatusList : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
