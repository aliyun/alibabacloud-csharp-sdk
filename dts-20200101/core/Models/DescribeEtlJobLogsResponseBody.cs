// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeEtlJobLogsResponseBody : TeaModel {
        /// <summary>
        /// The dynamic error code.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic part in the error message.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code. This example indicates that the specified ETL task ID is invalid.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message. This example indicates that the specified ETL task ID does not exist. In this case, the ETL task may be deleted.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The logs of ETL tasks.
        /// </summary>
        [NameInMap("EtlRunningLogs")]
        [Validation(Required=false)]
        public List<DescribeEtlJobLogsResponseBodyEtlRunningLogs> EtlRunningLogs { get; set; }
        public class DescribeEtlJobLogsResponseBodyEtlRunningLogs : TeaModel {
            /// <summary>
            /// The state of the ETL task.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The module for which the logs are generated, such as the conversion module of ETL tasks.
            /// </summary>
            [NameInMap("ContentKey")]
            [Validation(Required=false)]
            public string ContentKey { get; set; }

            /// <summary>
            /// The ID of the ETL task.
            /// </summary>
            [NameInMap("EtlId")]
            [Validation(Required=false)]
            public string EtlId { get; set; }

            /// <summary>
            /// The time when the log was generated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("LogDatetime")]
            [Validation(Required=false)]
            public string LogDatetime { get; set; }

            /// <summary>
            /// The log level. Valid values: ERROR, WARN, INFO, and DEBUG.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. If the call failed, false is returned.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
