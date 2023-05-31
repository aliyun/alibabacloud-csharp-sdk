// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryPreCheckDatabaseResponseBody : TeaModel {
        /// <summary>
        /// The time when the precheck task was complete.
        /// </summary>
        [NameInMap("CompletedTime")]
        [Validation(Required=false)]
        public long? CompletedTime { get; set; }

        /// <summary>
        /// The time when the precheck task was started.
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// The status of the precheck task. Valid values:
        /// 
        /// *   **completed**: complete
        /// *   **created**: started
        /// *   **error**: failed
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The precheck progress in percentage. Valid values: 0 to 100.
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the precheck task. The value is a JSON string that contains the following fields:
        /// 
        /// *   **instanceId**: the ID of the server that hosts the database
        /// 
        /// *   **checkTime**: the precheck time
        /// 
        /// *   **sourceType**: the database type
        /// 
        /// *   **results**: the precheck item and result
        /// 
        ///     *   **item**: the precheck item
        ///     *   **result**: the precheck result
        /// 
        /// > The following section describes the precheck items:
        /// 
        /// *   MSSQL
        /// 
        ///     *   **OSS_INTERNAL_ENDPOINT_CONNECTIVITY**: OSS connectivity check
        ///     *   **SERVICE_CONNECTIVITY**: control network connectivity check
        ///     *   **SQL_SERVER_DB_IN_SIMPLE_RECOVERY_MODE**: recovery mode check
        ///     *   **SQL_SERVER_DB_NOT_ONLINE**: SQL Server database status check
        /// 
        /// *   ORACLE
        /// 
        ///     *   **OSS_INTERNAL_ENDPOINT_CONNECTIVITY**: OSS connectivity check
        ///     *   **SERVICE_CONNECTIVITY**: control network connectivity check
        ///     *   **ORACLE_INSTANCE_STATUS**: Oracle instance status check
        ///     *   **ORACLE_DB_STATUS**: Oracle database status check
        ///     *   **ARCHIVELOG**: archive mode check
        /// 
        /// *   MYSQL
        /// 
        ///     *   **OSS_INTERNAL_ENDPOINT_CONNECTIVITY**: OSS connectivity check
        ///     *   **SERVICE_CONNECTIVITY**: control network connectivity check
        ///     *   **MYSQL_VERSION**: Supports full backup version checking
        ///     *   **MYSQL_BINLOG**: BINLOG check
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// The time when the precheck task was last updated.
        /// </summary>
        [NameInMap("UpdatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

    }

}
