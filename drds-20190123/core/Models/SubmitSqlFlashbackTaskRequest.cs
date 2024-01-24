// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitSqlFlashbackTaskRequest : TeaModel {
        /// <summary>
        /// The name of the DRDS database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of a DRDS instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The time when the SQL flashback task ends.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The restoration type. Valid values:
        /// 
        /// *   1: Image restoration
        /// *   0: reverse recovery
        /// </summary>
        [NameInMap("RecallRestoreType")]
        [Validation(Required=false)]
        public int? RecallRestoreType { get; set; }

        /// <summary>
        /// Exact match or fuzzy match. Valid values:
        /// 
        /// *   0: the exact match.
        /// *   1: the fuzzy match.
        /// </summary>
        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public int? RecallType { get; set; }

        /// <summary>
        /// The primary key of flashback SQL.
        /// </summary>
        [NameInMap("SqlPk")]
        [Validation(Required=false)]
        public string SqlPk { get; set; }

        /// <summary>
        /// The type of the SQL statement. Valid values: INSERT, UPDATE, and DELETE. Separate multiple types with commas (,).
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// The start time of the flashback SQL statement.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The name of the table where the flashback SQL operation was performed.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The Trace ID of the flashback SQL.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
