// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeClusterOperateLogsResponseBody : TeaModel {
        /// <summary>
        /// The error code returned by the backend service. The number is incremented.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the operation logs.
        /// </summary>
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public List<DescribeClusterOperateLogsResponseBodyDataPoints> DataPoints { get; set; }
        public class DescribeClusterOperateLogsResponseBodyDataPoints : TeaModel {
            /// <summary>
            /// Other description of the operation.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// The primary key of the log table.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The time when the operation is recorded. The value is in the UNIX timestamp format. Unit: milliseconds.
            /// </summary>
            [NameInMap("LogDatetime")]
            [Validation(Required=false)]
            public long? LogDatetime { get; set; }

            /// <summary>
            /// The value of the parameter after the operation if the operation is an UPDATE operation.
            /// </summary>
            [NameInMap("NewValue")]
            [Validation(Required=false)]
            public string NewValue { get; set; }

            /// <summary>
            /// The value of the parameter before the operation if the operation is an UPDATE operation.
            /// </summary>
            [NameInMap("OldValue")]
            [Validation(Required=false)]
            public string OldValue { get; set; }

            /// <summary>
            /// The type of the operation.
            /// </summary>
            [NameInMap("OperationName")]
            [Validation(Required=false)]
            public string OperationName { get; set; }

            /// <summary>
            /// The user who performed the operation.
            /// </summary>
            [NameInMap("OperationUser")]
            [Validation(Required=false)]
            public string OperationUser { get; set; }

            /// <summary>
            /// Indicates whether the request was successful. A value of **1** indicates that the request was successful.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public int? Success { get; set; }

        }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace %s in the ErrMessage parameter.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned for an exception.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of records.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
