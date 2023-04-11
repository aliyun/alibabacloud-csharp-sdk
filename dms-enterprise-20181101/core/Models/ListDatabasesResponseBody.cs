// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDatabasesResponseBody : TeaModel {
        /// <summary>
        /// The details of the databases.
        /// </summary>
        [NameInMap("DatabaseList")]
        [Validation(Required=false)]
        public ListDatabasesResponseBodyDatabaseList DatabaseList { get; set; }
        public class ListDatabasesResponseBodyDatabaseList : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<ListDatabasesResponseBodyDatabaseListDatabase> Database { get; set; }
            public class ListDatabasesResponseBodyDatabaseListDatabase : TeaModel {
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
                /// The type of the database engine.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The ID of the DBA.
                /// </summary>
                [NameInMap("DbaId")]
                [Validation(Required=false)]
                public string DbaId { get; set; }

                /// <summary>
                /// The nickname of the Database administrator (DBA) to which the database belongs.
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
                /// The type of the environment to which the database belongs.
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// The endpoint of the instance to which the database belongs.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The ID of the instance to which the database belongs.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The IDs of the owners of the database.
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListDatabasesResponseBodyDatabaseListDatabaseOwnerIdList OwnerIdList { get; set; }
                public class ListDatabasesResponseBodyDatabaseListDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// The nicknames of the database owners.
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListDatabasesResponseBodyDatabaseListDatabaseOwnerNameList OwnerNameList { get; set; }
                public class ListDatabasesResponseBodyDatabaseListDatabaseOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// The connection port of the instance to which the database belongs.
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
                /// The name that is used for searching the database.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// The system ID (SID) of the instance to which the database belongs.
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                /// <summary>
                /// The state of the database. Valid values:
                /// 
                /// *   NORMAL: The database is normal.
                /// *   DISABLE: The database is disabled.
                /// *   OFFLINE: The database is unpublished.
                /// *   NOT_EXIST: The database does not exist.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

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

        /// <summary>
        /// The number of databases that belong to an instance.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
