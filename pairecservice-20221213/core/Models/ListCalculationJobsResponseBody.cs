// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListCalculationJobsResponseBody : TeaModel {
        [NameInMap("CalculationJobs")]
        [Validation(Required=false)]
        public List<ListCalculationJobsResponseBodyCalculationJobs> CalculationJobs { get; set; }
        public class ListCalculationJobsResponseBodyCalculationJobs : TeaModel {
            [NameInMap("ABMetricName")]
            [Validation(Required=false)]
            public string ABMetricName { get; set; }

            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            [NameInMap("CalculationJobId")]
            [Validation(Required=false)]
            public string CalculationJobId { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("GmtRanTime")]
            [Validation(Required=false)]
            public string GmtRanTime { get; set; }

            [NameInMap("JobMessage")]
            [Validation(Required=false)]
            public List<string> JobMessage { get; set; }

            [NameInMap("JobSource")]
            [Validation(Required=false)]
            public string JobSource { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
