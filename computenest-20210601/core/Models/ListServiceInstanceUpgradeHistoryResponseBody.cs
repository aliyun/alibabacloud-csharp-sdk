// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceUpgradeHistoryResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("UpgradeHistory")]
        [Validation(Required=false)]
        public List<ListServiceInstanceUpgradeHistoryResponseBodyUpgradeHistory> UpgradeHistory { get; set; }
        public class ListServiceInstanceUpgradeHistoryResponseBodyUpgradeHistory : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("FromVersion")]
            [Validation(Required=false)]
            public string FromVersion { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public string Results { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ToVersion")]
            [Validation(Required=false)]
            public string ToVersion { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpgradeHistoryId")]
            [Validation(Required=false)]
            public string UpgradeHistoryId { get; set; }

        }

    }

}
