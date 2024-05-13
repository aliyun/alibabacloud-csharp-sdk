// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDatabaseResponseBody : TeaModel {
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
        /// The information about the databases.
        /// </summary>
        [NameInMap("SearchDatabaseList")]
        [Validation(Required=false)]
        public SearchDatabaseResponseBodySearchDatabaseList SearchDatabaseList { get; set; }
        public class SearchDatabaseResponseBodySearchDatabaseList : TeaModel {
            [NameInMap("SearchDatabase")]
            [Validation(Required=false)]
            public List<SearchDatabaseResponseBodySearchDatabaseListSearchDatabase> SearchDatabase { get; set; }
            public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabase : TeaModel {
                /// <summary>
                /// The alias of the database.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The name of the catalog to which the database belongs.
                /// 
                /// > If the type of the database engine is PostgreSQL, the name of the database is displayed.
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
                /// The name of the data link for cross-database queries.
                /// </summary>
                [NameInMap("DatalinkName")]
                [Validation(Required=false)]
                public string DatalinkName { get; set; }

                /// <summary>
                /// The type of the database engine.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The ID of the user who assumes the database administrator (DBA) role.
                /// </summary>
                [NameInMap("DbaId")]
                [Validation(Required=false)]
                public string DbaId { get; set; }

                /// <summary>
                /// The encoding method of the database.
                /// </summary>
                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                /// <summary>
                /// The environment type of the database. For more information, see [Change the environment type of an instance](https://help.aliyun.com/document_detail/163309.html).
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// The endpoint of the instance in which the database resides.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is not a logical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The IDs of the owners of the databases.
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerIdList OwnerIdList { get; set; }
                public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// The nicknames of the database owners.
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerNameList OwnerNameList { get; set; }
                public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// The port of the instance in which the database resides.
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
                /// The name that is used to search for the database.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                /// <summary>
                /// The system ID (SID) of the instance in which the database resides.
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
