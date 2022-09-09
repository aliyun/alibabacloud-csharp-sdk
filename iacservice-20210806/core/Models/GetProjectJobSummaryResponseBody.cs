// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProjectJobSummaryResponseBody : TeaModel {
        [NameInMap("jobSummary")]
        [Validation(Required=false)]
        public GetProjectJobSummaryResponseBodyJobSummary JobSummary { get; set; }
        public class GetProjectJobSummaryResponseBodyJobSummary : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<GetProjectJobSummaryResponseBodyJobSummaryDetail> Detail { get; set; }
            public class GetProjectJobSummaryResponseBodyJobSummaryDetail : TeaModel {
                [NameInMap("failCnt")]
                [Validation(Required=false)]
                public long? FailCnt { get; set; }

                [NameInMap("runningCnt")]
                [Validation(Required=false)]
                public long? RunningCnt { get; set; }

                [NameInMap("successCnt")]
                [Validation(Required=false)]
                public long? SuccessCnt { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            [NameInMap("failCnt")]
            [Validation(Required=false)]
            public long? FailCnt { get; set; }

            [NameInMap("runningCnt")]
            [Validation(Required=false)]
            public long? RunningCnt { get; set; }

            [NameInMap("successCnt")]
            [Validation(Required=false)]
            public long? SuccessCnt { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
