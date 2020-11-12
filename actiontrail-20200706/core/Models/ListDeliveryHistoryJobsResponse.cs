// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDeliveryHistoryJobsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("DeliveryHistoryJobs")]
        [Validation(Required=true)]
        public List<ListDeliveryHistoryJobsResponseDeliveryHistoryJobs> DeliveryHistoryJobs { get; set; }
        public class ListDeliveryHistoryJobsResponseDeliveryHistoryJobs : TeaModel {
            [NameInMap("TrailName")]
            [Validation(Required=true)]
            public string TrailName { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=true)]
            public string CreatedTime { get; set; }

            [NameInMap("UpdatedTime")]
            [Validation(Required=true)]
            public string UpdatedTime { get; set; }

            [NameInMap("HomeRegion")]
            [Validation(Required=true)]
            public string HomeRegion { get; set; }

        }

    }

}
