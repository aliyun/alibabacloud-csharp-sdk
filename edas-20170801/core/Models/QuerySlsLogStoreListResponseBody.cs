// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QuerySlsLogStoreListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of Log Service for the application.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QuerySlsLogStoreListResponseBodyResult> Result { get; set; }
        public class QuerySlsLogStoreListResponseBodyResult : TeaModel {
            /// <summary>
            /// The type of the logging service.
            /// </summary>
            [NameInMap("ConsumerSide")]
            [Validation(Required=false)]
            public string ConsumerSide { get; set; }

            /// <summary>
            /// The time when the logging service was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The URL of the logging service.
            /// </summary>
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// The name of the Logstore.
            /// </summary>
            [NameInMap("Logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// The name of the project.
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// The source of logs. Valid values:
            /// 
            /// *   Standard output: stdout.log
            /// *   File log: the directory that stores logs
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// The number of log sources configured for the application.
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
