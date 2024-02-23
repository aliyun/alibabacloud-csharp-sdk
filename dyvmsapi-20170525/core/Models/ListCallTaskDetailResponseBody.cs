// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ListCallTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   For more information about other response codes, see [API error codes](~~112502~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the task.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCallTaskDetailResponseBodyData> Data { get; set; }
        public class ListCallTaskDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The called number.
            /// </summary>
            [NameInMap("CalledNum")]
            [Validation(Required=false)]
            public string CalledNum { get; set; }

            /// <summary>
            /// The calling number.
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

            /// <summary>
            /// The call duration. Unit: seconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The task state. Valid values:
            /// 
            /// *   **SUCCESS**: The task was successful.
            /// *   **FAIL**: The task failed.
            /// *   **INIT**: The task was not started.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of called numbers.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
