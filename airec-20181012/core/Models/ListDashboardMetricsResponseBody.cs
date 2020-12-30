// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListDashboardMetricsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDashboardMetricsResponseBodyResult> Result { get; set; }
        public class ListDashboardMetricsResponseBodyResult : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public Dictionary<string, object> Total { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<ListDashboardMetricsResponseBodyResultDetail> Detail { get; set; }
            public class ListDashboardMetricsResponseBodyResultDetail : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Val")]
                [Validation(Required=false)]
                public string Val { get; set; }

            }

        }

    }

}
