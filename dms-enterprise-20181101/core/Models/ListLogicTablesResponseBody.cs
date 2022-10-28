// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicTablesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LogicTableList")]
        [Validation(Required=false)]
        public ListLogicTablesResponseBodyLogicTableList LogicTableList { get; set; }
        public class ListLogicTablesResponseBodyLogicTableList : TeaModel {
            [NameInMap("LogicTable")]
            [Validation(Required=false)]
            public List<ListLogicTablesResponseBodyLogicTableListLogicTable> LogicTable { get; set; }
            public class ListLogicTablesResponseBodyLogicTableListLogicTable : TeaModel {
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListLogicTablesResponseBodyLogicTableListLogicTableOwnerIdList OwnerIdList { get; set; }
                public class ListLogicTablesResponseBodyLogicTableListLogicTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListLogicTablesResponseBodyLogicTableListLogicTableOwnerNameList OwnerNameList { get; set; }
                public class ListLogicTablesResponseBodyLogicTableListLogicTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("TableCount")]
                [Validation(Required=false)]
                public string TableCount { get; set; }

                [NameInMap("TableExpr")]
                [Validation(Required=false)]
                public string TableExpr { get; set; }

                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
