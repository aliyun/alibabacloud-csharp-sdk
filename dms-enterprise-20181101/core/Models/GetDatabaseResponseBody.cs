// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDatabaseResponseBody : TeaModel {
        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to query the ID of the tenant.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public GetDatabaseResponseBodyDatabase Database { get; set; }
        public class GetDatabaseResponseBodyDatabase : TeaModel {
            /// <summary>
            /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
            /// </summary>
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// The names of the owners of the database.
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// The system identifier (SID) of the database.
            /// 
            /// >  The SID uniquely identifies an Oracle database. After a database is created, a SID is generated for the database.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The port that is used to connect to the database.
            /// </summary>
            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            /// <summary>
            /// The encoding format of the database.
            /// </summary>
            [NameInMap("DbaName")]
            [Validation(Required=false)]
            public string DbaName { get; set; }

            /// <summary>
            /// The port that is used to connect to the database.
            /// </summary>
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            /// <summary>
            /// The endpoint that is used to connect to the database.
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// The IDs of the owners of the database.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// The status of the database. Valid values:
            /// 
            /// *   **NORMAL**: The database is running as expected.
            /// *   **DISABLE**: The database is disabled.
            /// *   **OFFLINE**: The database is unpublished.
            /// *   **NOT_EXIST**: The database does not exist.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetDatabaseResponseBodyDatabaseOwnerIdList OwnerIdList { get; set; }
            public class GetDatabaseResponseBodyDatabaseOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            /// <summary>
            /// The ID of the database administrator (DBA).
            /// </summary>
            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetDatabaseResponseBodyDatabaseOwnerNameList OwnerNameList { get; set; }
            public class GetDatabaseResponseBodyDatabaseOwnerNameList : TeaModel {
                [NameInMap("OwnerNames")]
                [Validation(Required=false)]
                public List<string> OwnerNames { get; set; }

            }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// The nickname of the DBA.
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// The endpoint that is used to connect to the database.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
