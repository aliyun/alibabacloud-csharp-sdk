// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDeliveryHistoryJobsResponseBody : TeaModel {
        [NameInMap("DeliveryHistoryJobs")]
        [Validation(Required=false)]
        public List<ListDeliveryHistoryJobsResponseBodyDeliveryHistoryJobs> DeliveryHistoryJobs { get; set; }
        public class ListDeliveryHistoryJobsResponseBodyDeliveryHistoryJobs : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("HomeRegion")]
            [Validation(Required=false)]
            public string HomeRegion { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("TrailName")]
            [Validation(Required=false)]
            public string TrailName { get; set; }

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

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
