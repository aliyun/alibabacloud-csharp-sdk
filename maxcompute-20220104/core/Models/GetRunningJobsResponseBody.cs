// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRunningJobsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRunningJobsResponseBodyData Data { get; set; }
        public class GetRunningJobsResponseBodyData : TeaModel {
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("runningJobInfoList")]
            [Validation(Required=false)]
            public List<GetRunningJobsResponseBodyDataRunningJobInfoList> RunningJobInfoList { get; set; }
            public class GetRunningJobsResponseBodyDataRunningJobInfoList : TeaModel {
                [NameInMap("cuSnapshot")]
                [Validation(Required=false)]
                public double? CuSnapshot { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                [NameInMap("memorySnapshot")]
                [Validation(Required=false)]
                public double? MemorySnapshot { get; set; }

                [NameInMap("progress")]
                [Validation(Required=false)]
                public double? Progress { get; set; }

                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("quotaNickname")]
                [Validation(Required=false)]
                public string QuotaNickname { get; set; }

                [NameInMap("runningAtTime")]
                [Validation(Required=false)]
                public long? RunningAtTime { get; set; }

                [NameInMap("submittedAtTime")]
                [Validation(Required=false)]
                public long? SubmittedAtTime { get; set; }

            }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
