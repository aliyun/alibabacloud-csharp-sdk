// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicTablesResponseBody : TeaModel {
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
        /// The details of the logical tables.
        /// </summary>
        [NameInMap("LogicTableList")]
        [Validation(Required=false)]
        public ListLogicTablesResponseBodyLogicTableList LogicTableList { get; set; }
        public class ListLogicTablesResponseBodyLogicTableList : TeaModel {
            [NameInMap("LogicTable")]
            [Validation(Required=false)]
            public List<ListLogicTablesResponseBodyLogicTableListLogicTable> LogicTable { get; set; }
            public class ListLogicTablesResponseBodyLogicTableListLogicTable : TeaModel {
                /// <summary>
                /// The ID of the logical database.
                /// </summary>
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                /// <summary>
                /// Indicates whether the table is a logical table. The value is fixed to true.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The IDs of the owners of the logical tables.
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListLogicTablesResponseBodyLogicTableListLogicTableOwnerIdList OwnerIdList { get; set; }
                public class ListLogicTablesResponseBodyLogicTableListLogicTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// The nicknames of the owners of the logical tables.
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListLogicTablesResponseBodyLogicTableListLogicTableOwnerNameList OwnerNameList { get; set; }
                public class ListLogicTablesResponseBodyLogicTableListLogicTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// The logical database to which the logical table belongs.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The number of logical tables.
                /// </summary>
                [NameInMap("TableCount")]
                [Validation(Required=false)]
                public string TableCount { get; set; }

                /// <summary>
                /// The expression of the logical table.
                /// </summary>
                [NameInMap("TableExpr")]
                [Validation(Required=false)]
                public string TableExpr { get; set; }

                /// <summary>
                /// The GUID of the logical table.
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// The ID of the logical table.
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// The name of the logical table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

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
        /// The total number of logical tables that meet the query conditions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
