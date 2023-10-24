// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetJobResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetJobResourceUsageResponseBodyData Data { get; set; }
        public class GetJobResourceUsageResponseBodyData : TeaModel {
            /// <summary>
            /// The data list returned.
            /// </summary>
            [NameInMap("jobResourceUsageList")]
            [Validation(Required=false)]
            public List<GetJobResourceUsageResponseBodyDataJobResourceUsageList> JobResourceUsageList { get; set; }
            public class GetJobResourceUsageResponseBodyDataJobResourceUsageList : TeaModel {
                /// <summary>
                /// The total number of used compute units (CUs).
                /// </summary>
                [NameInMap("cuUsage")]
                [Validation(Required=false)]
                public long? CuUsage { get; set; }

                /// <summary>
                /// The start date of the query in the format of yyyy-MM-dd.
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// The job executor.
                /// </summary>
                [NameInMap("jobOwner")]
                [Validation(Required=false)]
                public string JobOwner { get; set; }

                /// <summary>
                /// The total memory usage.
                /// </summary>
                [NameInMap("memoryUsage")]
                [Validation(Required=false)]
                public long? MemoryUsage { get; set; }

                /// <summary>
                /// The quota nickname.
                /// </summary>
                [NameInMap("quotaNickname")]
                [Validation(Required=false)]
                public string QuotaNickname { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
