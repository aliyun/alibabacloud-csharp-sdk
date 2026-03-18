// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetJobResourceUsageResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetJobResourceUsageResponseBodyData Data { get; set; }
        public class GetJobResourceUsageResponseBodyData : TeaModel {
            [NameInMap("jobResourceUsageList")]
            [Validation(Required=false)]
            public List<GetJobResourceUsageResponseBodyDataJobResourceUsageList> JobResourceUsageList { get; set; }
            public class GetJobResourceUsageResponseBodyDataJobResourceUsageList : TeaModel {
                [NameInMap("cuUsage")]
                [Validation(Required=false)]
                public long? CuUsage { get; set; }

                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                [NameInMap("memoryUsage")]
                [Validation(Required=false)]
                public long? MemoryUsage { get; set; }

                [NameInMap("quotaNickname")]
                [Validation(Required=false)]
                public string QuotaNickname { get; set; }

            }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

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
