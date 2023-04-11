// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPhysicalDatabaseResponseBody : TeaModel {
        /// <summary>
        /// The information about the physical database.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public GetPhysicalDatabaseResponseBodyDatabase Database { get; set; }
        public class GetPhysicalDatabaseResponseBodyDatabase : TeaModel {
            /// <summary>
            /// The name of the catalog to which the database belongs.
            /// 
            /// > : If the database is a PostgreSQL database, the name of the database is displayed.
            /// </summary>
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// The ID of the physical database.
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// The type of the database engine.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The user ID of the DBA in the destination database.
            /// </summary>
            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            /// <summary>
            /// The nickname of the database administrator (DBA) in the destination database.
            /// </summary>
            [NameInMap("DbaName")]
            [Validation(Required=false)]
            public string DbaName { get; set; }

            /// <summary>
            /// The encoding format of the database.
            /// </summary>
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            /// <summary>
            /// The type of the environment to which the database belongs. For more information, see [Change the environment type of an instance](~~163309~~).
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// The endpoint that is used to connect to the database.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The instance ID of the destination database.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The user IDs of the database owners.
            /// </summary>
            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetPhysicalDatabaseResponseBodyDatabaseOwnerIdList OwnerIdList { get; set; }
            public class GetPhysicalDatabaseResponseBodyDatabaseOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            /// <summary>
            /// The nicknames of the database owners.
            /// </summary>
            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetPhysicalDatabaseResponseBodyDatabaseOwnerNameList OwnerNameList { get; set; }
            public class GetPhysicalDatabaseResponseBodyDatabaseOwnerNameList : TeaModel {
                [NameInMap("OwnerNames")]
                [Validation(Required=false)]
                public List<string> OwnerNames { get; set; }

            }

            /// <summary>
            /// The port that is used to connect to the database.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The name of the database.
            /// 
            /// > : If the database is a PostgreSQL database, the name of the mode is displayed.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The name that is used for searching the database.
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// The system ID (SID) of the database.
            /// 
            /// > : The value of the parameter is returned only for Oracle databases.
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// The state of the database. Valid values:
            /// 
            /// *   **NORMAL**: The database is normal.
            /// *   **DISABLE**: The database is disabled.
            /// *   **OFFLINE**: The database is unpublished.
            /// *   **NOT_EXIST**: The database does not exist.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
