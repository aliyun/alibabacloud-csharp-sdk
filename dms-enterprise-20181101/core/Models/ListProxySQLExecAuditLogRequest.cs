// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListProxySQLExecAuditLogRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value of this parameter must be a timestamp that follows the UNIX time format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The execution status of the SQL statement. Valid values:
        /// 
        /// *   **FAIL**: The execution of the SQL statement fails.
        /// *   **CANCEL**: The execution of the SQL statement is canceled.
        /// *   **SUCCESS**: The SQL statement is executed.
        /// </summary>
        [NameInMap("ExecState")]
        [Validation(Required=false)]
        public string ExecState { get; set; }

        /// <summary>
        /// The alias of the user.
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
        /// The number of entries to return on each page. Maximum values: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of SQL statement. Valid values:
        /// 
        /// *   **SELECT**
        /// *   **INSERT**
        /// *   **DELETE**
        /// *   **CREATE_TABLE**
        /// 
        /// >  You can choose Operation Audit > Secure Access Proxy in the top navigation bar of the DMS console to view more types of SQL statements.
        /// </summary>
        [NameInMap("SQLType")]
        [Validation(Required=false)]
        public string SQLType { get; set; }

        /// <summary>
        /// The name of the database instance.
        /// </summary>
        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value of this parameter must be a timestamp that follows the UNIX time format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
