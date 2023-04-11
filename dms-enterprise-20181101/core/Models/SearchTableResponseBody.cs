// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchTableResponseBody : TeaModel {
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
        /// The details of the tables.
        /// </summary>
        [NameInMap("SearchTableList")]
        [Validation(Required=false)]
        public SearchTableResponseBodySearchTableList SearchTableList { get; set; }
        public class SearchTableResponseBodySearchTableList : TeaModel {
            [NameInMap("SearchTable")]
            [Validation(Required=false)]
            public List<SearchTableResponseBodySearchTableListSearchTable> SearchTable { get; set; }
            public class SearchTableResponseBodySearchTableListSearchTable : TeaModel {
                /// <summary>
                /// The name that is used to search for the database to which the table belongs.
                /// </summary>
                [NameInMap("DBSearchName")]
                [Validation(Required=false)]
                public string DBSearchName { get; set; }

                /// <summary>
                /// The ID of the database to which the table belongs.
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// The type of the database. Valid values:
                /// 
                /// *   **MySQL**
                /// *   **SQLServer**
                /// *   **PostgreSQL**
                /// *   **Oracle**
                /// *   **DRDS**
                /// *   **OceanBase**
                /// *   **Mongo**
                /// *   **Redis**
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The description of the table.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The encoding format of the table.
                /// </summary>
                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                /// <summary>
                /// The engine of the table.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The type of the environment to which the database belongs.
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// Indicates whether the table is a logical table. Valid values:
                /// 
                /// *   **true**: The table is a logical table.
                /// *   **false**: The table is not a logical table.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The IDs of the table owners.
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public SearchTableResponseBodySearchTableListSearchTableOwnerIdList OwnerIdList { get; set; }
                public class SearchTableResponseBodySearchTableListSearchTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// The nicknames of the table owners.
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public SearchTableResponseBodySearchTableListSearchTableOwnerNameList OwnerNameList { get; set; }
                public class SearchTableResponseBodySearchTableListSearchTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// The GUID of the table.
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// The ID of the table.
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The name of the database to which the table belongs.
                /// </summary>
                [NameInMap("TableSchemaName")]
                [Validation(Required=false)]
                public string TableSchemaName { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
