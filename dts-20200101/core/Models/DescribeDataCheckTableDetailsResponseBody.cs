// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDataCheckTableDetailsResponseBody : TeaModel {
        /// <summary>
        /// The number of tables that contain inconsistent data.
        /// </summary>
        [NameInMap("DiffTableCount")]
        [Validation(Required=false)]
        public long? DiffTableCount { get; set; }

        /// <summary>
        /// The dynamic error code. This parameter will be removed in the future.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace the **%s** variable in the value of **ErrMessage**.
        /// 
        /// >  For example, if the return value of **ErrMessage** is **The Value of Input Parameter %s is not valid** and the return value of **DynamicMessage** is **Type**, the specified value of **Type** is invalid.
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
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The total number of data rows that were verified.
        /// </summary>
        [NameInMap("FinishedCount")]
        [Validation(Required=false)]
        public long? FinishedCount { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The request ID.
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
        /// The details of data verification results.
        /// </summary>
        [NameInMap("TableDetails")]
        [Validation(Required=false)]
        public List<DescribeDataCheckTableDetailsResponseBodyTableDetails> TableDetails { get; set; }
        public class DescribeDataCheckTableDetailsResponseBodyTableDetails : TeaModel {
            /// <summary>
            /// The time when data verification was performed.
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// The number of data rows that contain inconsistent data.
            /// </summary>
            [NameInMap("DiffCount")]
            [Validation(Required=false)]
            public long? DiffCount { get; set; }

            /// <summary>
            /// The error code returned if the request failed.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// The number of data rows that were verified.
            /// </summary>
            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public long? FinishCount { get; set; }

            /// <summary>
            /// The auto-increment primary key that is used to identify the data in a verification result.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the source database.
            /// </summary>
            [NameInMap("SourceDbName")]
            [Validation(Required=false)]
            public string SourceDbName { get; set; }

            /// <summary>
            /// The name of the source table.
            /// </summary>
            [NameInMap("SourceTbName")]
            [Validation(Required=false)]
            public string SourceTbName { get; set; }

            /// <summary>
            /// The state of the data verification task. Valid values:
            /// 
            /// *   **0**: The data verification task was complete.
            /// *   **2**: The data verification task was being initialized.
            /// *   **3**: The data verification task was in progress.
            /// *   **5**: The data verification task failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the destination database.
            /// </summary>
            [NameInMap("TargetDbName")]
            [Validation(Required=false)]
            public string TargetDbName { get; set; }

            /// <summary>
            /// The name of the destination table.
            /// </summary>
            [NameInMap("TargetTbName")]
            [Validation(Required=false)]
            public string TargetTbName { get; set; }

            /// <summary>
            /// The total number of data rows.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The total number of tables on which data verification was performed.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
