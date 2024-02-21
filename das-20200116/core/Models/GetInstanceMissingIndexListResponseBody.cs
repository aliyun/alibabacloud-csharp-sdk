// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceMissingIndexListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceMissingIndexListResponseBodyData Data { get; set; }
        public class GetInstanceMissingIndexListResponseBodyData : TeaModel {
            /// <summary>
            /// The returned data.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetInstanceMissingIndexListResponseBodyDataList> List { get; set; }
            public class GetInstanceMissingIndexListResponseBodyDataList : TeaModel {
                /// <summary>
                /// The average cost savings.
                /// </summary>
                [NameInMap("AvgTotalUserCost")]
                [Validation(Required=false)]
                public double? AvgTotalUserCost { get; set; }

                /// <summary>
                /// The performance improvement, in percentage.
                /// </summary>
                [NameInMap("AvgUserImpact")]
                [Validation(Required=false)]
                public double? AvgUserImpact { get; set; }

                /// <summary>
                /// The statement used to create the missing indexes.
                /// </summary>
                [NameInMap("CreateIndex")]
                [Validation(Required=false)]
                public string CreateIndex { get; set; }

                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// The index columns included in the equal operation.
                /// </summary>
                [NameInMap("EqualityColumns")]
                [Validation(Required=false)]
                public string EqualityColumns { get; set; }

                /// <summary>
                /// The columns on which indexes are missing.
                /// </summary>
                [NameInMap("IncludedColumns")]
                [Validation(Required=false)]
                public string IncludedColumns { get; set; }

                /// <summary>
                /// The number of indexes.
                /// </summary>
                [NameInMap("IndexCount")]
                [Validation(Required=false)]
                public long? IndexCount { get; set; }

                /// <summary>
                /// The index columns included in the not equal operation.
                /// </summary>
                [NameInMap("InequalityColumns")]
                [Validation(Required=false)]
                public string InequalityColumns { get; set; }

                /// <summary>
                /// The last seek time of a user.
                /// </summary>
                [NameInMap("LastUserSeek")]
                [Validation(Required=false)]
                public long? LastUserSeek { get; set; }

                /// <summary>
                /// The object name.
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// The total number of returned pages.
                /// </summary>
                [NameInMap("ReservedPages")]
                [Validation(Required=false)]
                public long? ReservedPages { get; set; }

                /// <summary>
                /// The table size.
                /// </summary>
                [NameInMap("ReservedSize")]
                [Validation(Required=false)]
                public double? ReservedSize { get; set; }

                /// <summary>
                /// The number of table rows.
                /// </summary>
                [NameInMap("RowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

                /// <summary>
                /// The schema name.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The number of scans.
                /// </summary>
                [NameInMap("SystemScans")]
                [Validation(Required=false)]
                public long? SystemScans { get; set; }

                /// <summary>
                /// The number of seeks.
                /// </summary>
                [NameInMap("SystemSeeks")]
                [Validation(Required=false)]
                public long? SystemSeeks { get; set; }

                /// <summary>
                /// The number of compilations.
                /// </summary>
                [NameInMap("UniqueCompiles")]
                [Validation(Required=false)]
                public long? UniqueCompiles { get; set; }

                /// <summary>
                /// The number of scans performed by users.
                /// </summary>
                [NameInMap("UserScans")]
                [Validation(Required=false)]
                public long? UserScans { get; set; }

                /// <summary>
                /// The number of seeks performed by users.
                /// </summary>
                [NameInMap("UserSeeks")]
                [Validation(Required=false)]
                public long? UserSeeks { get; set; }

            }

            /// <summary>
            /// The page number of the page returned.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
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
        public string Success { get; set; }

    }

}
