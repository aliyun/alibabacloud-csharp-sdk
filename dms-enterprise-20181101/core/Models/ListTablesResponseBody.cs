// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTablesResponseBody : TeaModel {
        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The details of the tables.
        /// </summary>
        [NameInMap("TableList")]
        [Validation(Required=false)]
        public ListTablesResponseBodyTableList TableList { get; set; }
        public class ListTablesResponseBodyTableList : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyTableListTable> Table { get; set; }
            public class ListTablesResponseBodyTableListTable : TeaModel {
                /// <summary>
                /// The ID of the physical database.
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

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
                /// The number of rows in the table. This is a statistical value and does not indicate the actual number of rows.
                /// </summary>
                [NameInMap("NumRows")]
                [Validation(Required=false)]
                public long? NumRows { get; set; }

                /// <summary>
                /// The ID list of the table owners.
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListTablesResponseBodyTableListTableOwnerIdList OwnerIdList { get; set; }
                public class ListTablesResponseBodyTableListTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// The nickname list of the table owners.
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListTablesResponseBodyTableListTableOwnerNameList OwnerNameList { get; set; }
                public class ListTablesResponseBodyTableListTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// The storage space that is occupied by the table. This is a statistical value and does not indicate the accurate storage space. Unit: MB.
                /// </summary>
                [NameInMap("StoreCapacity")]
                [Validation(Required=false)]
                public long? StoreCapacity { get; set; }

                /// <summary>
                /// The GUID of the table in DMS.
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
                /// The table name.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The database in which the table resides.
                /// </summary>
                [NameInMap("TableSchemaName")]
                [Validation(Required=false)]
                public string TableSchemaName { get; set; }

                /// <summary>
                /// The type of the table. Default value: NORMAL.
                /// </summary>
                [NameInMap("TableType")]
                [Validation(Required=false)]
                public string TableType { get; set; }

            }

        }

        /// <summary>
        /// The total number of tables that meet the query conditions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
