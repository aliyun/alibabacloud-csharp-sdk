// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeIceDurSummaryOverviewResponseBody : TeaModel {
        [NameInMap("JobInfoList")]
        [Validation(Required=false)]
        public List<DescribeIceDurSummaryOverviewResponseBodyJobInfoList> JobInfoList { get; set; }
        public class DescribeIceDurSummaryOverviewResponseBodyJobInfoList : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            [NameInMap("TimeRange")]
            [Validation(Required=false)]
            public string TimeRange { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
