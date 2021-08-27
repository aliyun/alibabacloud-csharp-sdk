// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupHistoryResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("AutoProvisioningGroupHistories")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories AutoProvisioningGroupHistories { get; set; }
        public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories : TeaModel {
            [NameInMap("AutoProvisioningGroupHistory")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistory> AutoProvisioningGroupHistory { get; set; }
            public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistory : TeaModel {
                public string Status { get; set; }
                public string StartTime { get; set; }
                public string TaskId { get; set; }
                public string LastEventTime { get; set; }
                public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetails ActivityDetails { get; set; }
                public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetails : TeaModel {
                    [NameInMap("ActivityDetail")]
                    [Validation(Required=false)]
                    public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetail> ActivityDetail { get; set; }
                    public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetail : TeaModel {
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public string Detail { get; set; }

                    }

                }
            }
        };

    }

}
