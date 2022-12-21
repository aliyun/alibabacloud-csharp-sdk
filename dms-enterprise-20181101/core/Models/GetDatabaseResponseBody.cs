// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDatabaseResponseBody : TeaModel {
        /// <summary>
        /// The details of the database.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public GetDatabaseResponseBodyDatabase Database { get; set; }
        public class GetDatabaseResponseBodyDatabase : TeaModel {
            /// <summary>
            /// The name of the catalog to which the database belongs.
            /// </summary>
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// The ID of the database.
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The ID of the database administrator (DBA).
            /// </summary>
            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            /// <summary>
            /// The nickname of the DBA.
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
            /// The type of the environment to which the database belongs. Valid values:
            /// 
            /// *   **product**: production environment
            /// *   **dev**: development environment
            /// *   **pre**: staging environment
            /// *   **test**: test environment
            /// *   **sit**: SIT environment
            /// *   **uat**: user acceptance testing (UAT) environment
            /// *   **pet**: stress testing environment
            /// *   **stag**: STAG environment
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
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The IDs of the owners of the database.
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
            /// The names of the owners of the database.
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
            /// The port that is used to connect to the database.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The keyword that is used to search for the database.
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// The SID of the database.
            /// 
            /// >  The value of the parameter is returned only for Oracle databases.
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// The status of the database. Valid values:
            /// 
            /// *   **NORMAL**: The database is running as expected.
            /// *   **DISABLE**: The database is disabled.
            /// *   **OFFLINE**: The database is unpublished.
            /// *   **NOT_EXIST**: The database does not exist.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
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
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
