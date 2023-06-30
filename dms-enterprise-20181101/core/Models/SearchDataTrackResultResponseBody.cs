// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDataTrackResultResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The parsing result of the data tracking task.
        /// </summary>
        [NameInMap("TrackResult")]
        [Validation(Required=false)]
        public SearchDataTrackResultResponseBodyTrackResult TrackResult { get; set; }
        public class SearchDataTrackResultResponseBodyTrackResult : TeaModel {
            /// <summary>
            /// The details of the event logs.
            /// </summary>
            [NameInMap("EventList")]
            [Validation(Required=false)]
            public List<SearchDataTrackResultResponseBodyTrackResultEventList> EventList { get; set; }
            public class SearchDataTrackResultResponseBodyTrackResultEventList : TeaModel {
                /// <summary>
                /// The data records after you perform data operations in the database.
                /// </summary>
                [NameInMap("DataAfter")]
                [Validation(Required=false)]
                public List<string> DataAfter { get; set; }

                /// <summary>
                /// The data records before you perform data operations in the database.
                /// </summary>
                [NameInMap("DataBefore")]
                [Validation(Required=false)]
                public List<string> DataBefore { get; set; }

                /// <summary>
                /// The ID of the event.
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public long? EventId { get; set; }

                /// <summary>
                /// The length of the event content. Unit: bytes.
                /// </summary>
                [NameInMap("EventLength")]
                [Validation(Required=false)]
                public long? EventLength { get; set; }

                /// <summary>
                /// The event time.
                /// </summary>
                [NameInMap("EventTimestamp")]
                [Validation(Required=false)]
                public string EventTimestamp { get; set; }

                /// <summary>
                /// The type of the event. Valid values:
                /// 
                /// *   **WRITE_ROWS**: indicates an INSERT operation.
                /// *   **UPDATE_ROWS**: indicates an UPDATE operation.
                /// *   **DELETE_ROWS**: indicates a DELETE operation.
                /// *   **EXT_WRITE_ROWS**: indicates an INSERT operation, which is equivalent to WRITE_ROWS.
                /// *   **EXT_UPDATE_ROWS**: indicates an UPDATE operation, which is equivalent to UPDATE_ROWS.
                /// *   **EXT_DELETE_ROWS**: indicates a DELETE operation, which is equivalent to DELETE_ROWS.
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The SQL statements used to roll back the data change.
                /// </summary>
                [NameInMap("RollSQL")]
                [Validation(Required=false)]
                public string RollSQL { get; set; }

            }

            /// <summary>
            /// The metadata of tables for which you track data operations.
            /// </summary>
            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<SearchDataTrackResultResponseBodyTrackResultTableInfoList> TableInfoList { get; set; }
            public class SearchDataTrackResultResponseBodyTrackResultTableInfoList : TeaModel {
                /// <summary>
                /// The information about columns.
                /// </summary>
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<SearchDataTrackResultResponseBodyTrackResultTableInfoListColumns> Columns { get; set; }
                public class SearchDataTrackResultResponseBodyTrackResultTableInfoListColumns : TeaModel {
                    /// <summary>
                    /// The name of the column.
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// The position of the column.
                    /// </summary>
                    [NameInMap("ColumnPosition")]
                    [Validation(Required=false)]
                    public int? ColumnPosition { get; set; }

                    /// <summary>
                    /// The data type of the column. Examples: BIGINT, INT, and VARCHAR.
                    /// </summary>
                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                    /// <summary>
                    /// Indicates whether the column is a virtual column. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("Fictive")]
                    [Validation(Required=false)]
                    public bool? Fictive { get; set; }

                }

                /// <summary>
                /// The description of the column.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
