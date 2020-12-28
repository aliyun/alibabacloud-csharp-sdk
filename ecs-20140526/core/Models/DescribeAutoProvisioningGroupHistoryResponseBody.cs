// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupHistoryResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("AutoProvisioningGroupHistories")]
        [Validation(Required=false)]
        public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories> AutoProvisioningGroupHistories { get; set; }
        public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("ActivityDetails")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesActivityDetails> ActivityDetails { get; set; }
            public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesActivityDetails : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

            }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("LastEventTime")]
            [Validation(Required=false)]
            public string LastEventTime { get; set; }

        }

    }

}
