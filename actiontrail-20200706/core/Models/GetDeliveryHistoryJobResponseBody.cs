// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetDeliveryHistoryJobResponseBody : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<GetDeliveryHistoryJobResponseBodyStatus> Status { get; set; }
        public class GetDeliveryHistoryJobResponseBodyStatus : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("TrailName")]
        [Validation(Required=false)]
        public string TrailName { get; set; }

        [NameInMap("UpdatedTime")]
        [Validation(Required=false)]
        public string UpdatedTime { get; set; }

    }

}
