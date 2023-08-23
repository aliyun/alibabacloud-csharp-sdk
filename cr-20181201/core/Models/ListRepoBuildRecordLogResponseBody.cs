// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRecordLogResponseBody : TeaModel {
        /// <summary>
        /// The log content of the image building record.
        /// </summary>
        [NameInMap("BuildRecordLogs")]
        [Validation(Required=false)]
        public List<ListRepoBuildRecordLogResponseBodyBuildRecordLogs> BuildRecordLogs { get; set; }
        public class ListRepoBuildRecordLogResponseBodyBuildRecordLogs : TeaModel {
            /// <summary>
            /// The stage of the building that is recorded in the log entry.
            /// </summary>
            [NameInMap("BuildStage")]
            [Validation(Required=false)]
            public string BuildStage { get; set; }

            /// <summary>
            /// The line number of the log entry.
            /// </summary>
            [NameInMap("LineNumber")]
            [Validation(Required=false)]
            public int? LineNumber { get; set; }

            /// <summary>
            /// The content of the log.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
