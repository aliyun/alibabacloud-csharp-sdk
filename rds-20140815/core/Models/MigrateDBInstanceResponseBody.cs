// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class MigrateDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// The serial number of the task in the migration task queue. When the serial number becomes 0, the system starts the migration.
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public int? MigrationId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
