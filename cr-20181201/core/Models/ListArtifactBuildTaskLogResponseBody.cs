// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListArtifactBuildTaskLogResponseBody : TeaModel {
        /// <summary>
        /// The log entries of the artifact build task.
        /// </summary>
        [NameInMap("BuildTaskLogs")]
        [Validation(Required=false)]
        public List<ListArtifactBuildTaskLogResponseBodyBuildTaskLogs> BuildTaskLogs { get; set; }
        public class ListArtifactBuildTaskLogResponseBodyBuildTaskLogs : TeaModel {
            /// <summary>
            /// The row number of the log entry.
            /// </summary>
            [NameInMap("LineNumber")]
            [Validation(Required=false)]
            public int? LineNumber { get; set; }

            /// <summary>
            /// The content of the log entry.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the API call is successful.
        /// 
        /// *   `true`: successful
        /// *   `false`: failed
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of log entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
