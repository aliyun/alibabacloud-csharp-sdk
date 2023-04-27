// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDBTaskSQLJobDetailRequest : TeaModel {
        /// <summary>
        /// The number of times that the SQL statement was executed.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// The status of the SQL task. Valid values:
        /// 
        /// *   **INIT**: The SQL task was initialized.
        /// *   **PENDING**: The SQL task waited to be run.
        /// *   **BE_SCHEDULED**: The SQL task waited to be scheduled.
        /// *   **FAIL**: The SQL task failed.
        /// *   **SUCCESS**: The SQL task was successful.
        /// *   **PAUSE**: The SQL task was paused.
        /// *   **DELETE**: The SQL task was deleted.
        /// *   **RUNNING**: The SQL task was being run.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The error code that is returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the physical database.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
