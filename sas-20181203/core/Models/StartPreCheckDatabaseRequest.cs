// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartPreCheckDatabaseRequest : TeaModel {
        /// <summary>
        /// The type of the database. Valid values:
        /// 
        /// *   **MYSQL**
        /// *   **MSSQL**
        /// *   **Oracle**
        /// </summary>
        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        /// <summary>
        /// The UUID of the agent that is used to back up the data of the database.
        /// 
        /// > You can call the [DescribeUniBackupDatabase](~~DescribeUniBackupDatabase~~) operation to query the UUID.
        /// </summary>
        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

        /// <summary>
        /// The region ID of the server that hosts the database.
        /// </summary>
        [NameInMap("UniRegionId")]
        [Validation(Required=false)]
        public string UniRegionId { get; set; }

    }

}
