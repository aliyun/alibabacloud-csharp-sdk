// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeSqlFlashbakTaskResponseBody : TeaModel {
        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates the information about flashback tasks.
        /// </summary>
        [NameInMap("SqlFlashbackTasks")]
        [Validation(Required=false)]
        public DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasks SqlFlashbackTasks { get; set; }
        public class DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasks : TeaModel {
            [NameInMap("SqlFlashbackTask")]
            [Validation(Required=false)]
            public List<DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasksSqlFlashbackTask> SqlFlashbackTask { get; set; }
            public class DescribeSqlFlashbakTaskResponseBodySqlFlashbackTasksSqlFlashbackTask : TeaModel {
                /// <summary>
                /// Indicates the name of the database on which a flashback task is performed.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// Indicates the download URL.
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// Indicates the time when the download URL expires.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// Indicates the point in time when the instance was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// Indicates the point in time when the flashback task is performed.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// Indicates the ID of the primary key that corresponds to a table used in the flashback task.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// Indicates the ID of the instance.
                /// </summary>
                [NameInMap("InstId")]
                [Validation(Required=false)]
                public string InstId { get; set; }

                /// <summary>
                /// Indicates the progress of the reverse call.
                /// </summary>
                [NameInMap("RecallProgress")]
                [Validation(Required=false)]
                public int? RecallProgress { get; set; }

                /// <summary>
                /// Indicates the type of the flashback task. Valid values:
                /// 
                /// *   **1**: image restoration
                /// *   **2**: reverse restoration
                /// </summary>
                [NameInMap("RecallRestoreType")]
                [Validation(Required=false)]
                public int? RecallRestoreType { get; set; }

                /// <summary>
                /// Indicates the status of the data recall task.
                /// </summary>
                [NameInMap("RecallStatus")]
                [Validation(Required=false)]
                public int? RecallStatus { get; set; }

                /// <summary>
                /// Indicates the type of the reverse call. Valid values:
                /// 
                /// *   **0**: exact search
                /// *   **1**: fuzzy search
                /// </summary>
                [NameInMap("RecallType")]
                [Validation(Required=false)]
                public int? RecallType { get; set; }

                /// <summary>
                /// Indicates the start time of the reverse call.
                /// </summary>
                [NameInMap("SearchEndTime")]
                [Validation(Required=false)]
                public long? SearchEndTime { get; set; }

                /// <summary>
                /// Indicates the end time of the reverse call.
                /// </summary>
                [NameInMap("SearchStartTime")]
                [Validation(Required=false)]
                public long? SearchStartTime { get; set; }

                /// <summary>
                /// Indicates the number of data rows that are flashed back.
                /// </summary>
                [NameInMap("SqlCounter")]
                [Validation(Required=false)]
                public long? SqlCounter { get; set; }

                /// <summary>
                /// Indicates the primary key specified in the SQL statements.
                /// </summary>
                [NameInMap("SqlPk")]
                [Validation(Required=false)]
                public string SqlPk { get; set; }

                /// <summary>
                /// Indicates the types of the SQL statements.
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// Indicates the name of the table that contains the data that are flashed back.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// Indicates the ID of the trace of the SQL query.
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
