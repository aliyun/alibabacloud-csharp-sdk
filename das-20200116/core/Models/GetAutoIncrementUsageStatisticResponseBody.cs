// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoIncrementUsageStatisticResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoIncrementUsageStatisticResponseBodyData Data { get; set; }
        public class GetAutoIncrementUsageStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// The usage details of auto-increment IDs.
            /// </summary>
            [NameInMap("AutoIncrementUsageList")]
            [Validation(Required=false)]
            public List<GetAutoIncrementUsageStatisticResponseBodyDataAutoIncrementUsageList> AutoIncrementUsageList { get; set; }
            public class GetAutoIncrementUsageStatisticResponseBodyDataAutoIncrementUsageList : TeaModel {
                /// <summary>
                /// The latest auto-increment ID.
                /// </summary>
                [NameInMap("AutoIncrementCurrentValue")]
                [Validation(Required=false)]
                public long? AutoIncrementCurrentValue { get; set; }

                /// <summary>
                /// The usage ratio of auto-increment IDs.
                /// </summary>
                [NameInMap("AutoIncrementRatio")]
                [Validation(Required=false)]
                public double? AutoIncrementRatio { get; set; }

                /// <summary>
                /// The column name.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// The maximum auto-increment ID that is supported by the current data type.
                /// </summary>
                [NameInMap("MaximumValue")]
                [Validation(Required=false)]
                public long? MaximumValue { get; set; }

                /// <summary>
                /// The table name.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The error message returned if the task fails.
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

            /// <summary>
            /// Indicates whether the task is complete. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Finish")]
            [Validation(Required=false)]
            public bool? Finish { get; set; }

            /// <summary>
            /// The task status. Valid values:
            /// 
            /// *   **INIT**: The task is being initialized.
            /// *   **RUNNING**: The task is being executed.
            /// *   **SUCCESS**: The task succeeds.
            /// *   **FAIL**: The task fails.
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// The time when the request was made. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request is successful, **Successful** is returned. Otherwise, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
