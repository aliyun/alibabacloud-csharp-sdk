// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLExecAuditLogRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query.
        /// 
        /// >  The end time supports fuzzy match. Specify the time in the YYYY-MM-DD hh:mm:ss format. We recommend that you use the StartTime and EndTime parameters to specify a time range that does not exceed one day. The returned entries can be displayed by page to improve query efficiency.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The execution status of the SQL statement. Valid values:
        /// 
        /// *   **FAIL**: The SQL statement fails to be executed.
        /// *   **NOEXE**: The SQL statement has not been executed.
        /// *   **RUNNING**: The SQL statement is being executed.
        /// *   **CANCEL**: The execution of the SQL statement is canceled.
        /// *   **SUCCESS**: The SQL statement is executed.
        /// </summary>
        [NameInMap("ExecState")]
        [Validation(Required=false)]
        public string ExecState { get; set; }

        /// <summary>
        /// The nickname of the user who wrote the SQL statement.
        /// </summary>
        [NameInMap("OpUserName")]
        [Validation(Required=false)]
        public string OpUserName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. The value cannot exceed 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the database or instance based on which you want to query SQL statements.
        /// 
        /// >  If the SQL statements to be queried are at the instance level, you can set this parameter to an instance name. If the SQL statements to be queried are at the database level, you can set this parameter to a database name.
        /// </summary>
        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// The type of the SQL statement. Valid values:
        /// 
        /// *   **SELECT**: the SQL statement that is used to query data.
        /// *   **INSERT**: the SQL statement that is used to insert data.
        /// *   **DELETE**: the SQL statement that is used to delete data.
        /// *   **CREATE_TABLE**: the SQL statement that is used to create tables.
        /// 
        /// >  To view more types of SQL statements, log on to the DMS console and click Security and Specifications. In the left-side navigation pane, click **Operation Audit**. Then, you can view all supported types of SQL statements from the **SQL type** drop-down list.
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// >  The start time supports fuzzy match. Specify the time in the YYYY-MM-DD hh:mm:ss format.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
