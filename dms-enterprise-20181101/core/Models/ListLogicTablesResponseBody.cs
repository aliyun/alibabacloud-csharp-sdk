// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicTablesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("LogicTableList")]
        [Validation(Required=false)]
        public ListLogicTablesResponseBodyLogicTableList LogicTableList { get; set; }
        public class ListLogicTablesResponseBodyLogicTableList : TeaModel {
            [NameInMap("LogicTable")]
            [Validation(Required=false)]
            public List<ListLogicTablesResponseBodyLogicTableListLogicTable> LogicTable { get; set; }
            public class ListLogicTablesResponseBodyLogicTableListLogicTable : TeaModel {
                public string DatabaseId { get; set; }
                public string TableName { get; set; }
                public string TableCount { get; set; }
                public ListLogicTablesResponseBodyLogicTableListLogicTableOwnerIdList OwnerIdList { get; set; }
                public class ListLogicTablesResponseBodyLogicTableListLogicTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }
                public ListLogicTablesResponseBodyLogicTableListLogicTableOwnerNameList OwnerNameList { get; set; }
                public class ListLogicTablesResponseBodyLogicTableListLogicTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }
                public string SchemaName { get; set; }
                public bool? Logic { get; set; }
                public string TableExpr { get; set; }
                public string TableGuid { get; set; }
                public string TableId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
