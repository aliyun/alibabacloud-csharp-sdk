// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListSearchLogResponseBody : TeaModel {
        /// <summary>
        /// The level of the log. Valid values:
        /// 
        /// *   warn: warning log
        /// *   info: information log
        /// *   error: error log
        /// *   trace: trace logs
        /// *   debug: debug logs
        /// 
        /// The level information has been migrated to the contentCollection field.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListSearchLogResponseBodyHeaders Headers { get; set; }
        public class ListSearchLogResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The IP address of the node that generates the log.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The list of logs returned by the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The content of the log entry. Migrated to the contentCollection field.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListSearchLogResponseBodyResult> Result { get; set; }
        public class ListSearchLogResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("contentCollection")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentCollection { get; set; }

            /// <summary>
            /// Details of the log entry. Different content fields are returned for different log types.
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The timestamp when the log is generated. Unit: ms.
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
