// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupDatabaseResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the information about the databases.
        /// </summary>
        [NameInMap("DatabaseList")]
        [Validation(Required=false)]
        public List<DescribeUniBackupDatabaseResponseBodyDatabaseList> DatabaseList { get; set; }
        public class DescribeUniBackupDatabaseResponseBodyDatabaseList : TeaModel {
            /// <summary>
            /// The status of the anti-ransomware agent. Valid values:
            /// 
            /// *   **UNKNOWN**: unknown
            /// *   **INSTALLED**: installed
            /// *   **INSTALL_FAILED**: installation failed
            /// *   **UNINSTALL_FAILED**: uninstallation failed
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// The service from which the database is created. Valid values:
            /// 
            /// *   **HBR**: HBR
            /// *   **AEGIS**: Security Center
            /// </summary>
            [NameInMap("CreatedByProduct")]
            [Validation(Required=false)]
            public string CreatedByProduct { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

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
            /// The version of the database engine.
            /// </summary>
            [NameInMap("DatabaseVersion")]
            [Validation(Required=false)]
            public string DatabaseVersion { get; set; }

            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance to which the database belongs.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The UUID of the Hybrid Backup Recovery (HBR) agent that is used to back up the data of the database.
            /// </summary>
            [NameInMap("InstanceUuid")]
            [Validation(Required=false)]
            public string InstanceUuid { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// The status of the ECS instance. Valid values:
            /// 
            /// *   **Stopped**
            /// *   **Running**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeUniBackupDatabaseResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeUniBackupDatabaseResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
