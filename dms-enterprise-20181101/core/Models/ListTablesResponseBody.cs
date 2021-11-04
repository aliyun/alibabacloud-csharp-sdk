// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTablesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TableList")]
        [Validation(Required=false)]
        public ListTablesResponseBodyTableList TableList { get; set; }
        public class ListTablesResponseBodyTableList : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyTableListTable> Table { get; set; }
            public class ListTablesResponseBodyTableListTable : TeaModel {
                public string DatabaseId { get; set; }
                public string Description { get; set; }
                public string Encoding { get; set; }
                public string Engine { get; set; }
                public long? NumRows { get; set; }
                public ListTablesResponseBodyTableListTableOwnerIdList OwnerIdList { get; set; }
                public class ListTablesResponseBodyTableListTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }
                public ListTablesResponseBodyTableListTableOwnerNameList OwnerNameList { get; set; }
                public class ListTablesResponseBodyTableListTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }
                public long? StoreCapacity { get; set; }
                public string TableGuid { get; set; }
                public string TableId { get; set; }
                public string TableName { get; set; }
                public string TableSchemaName { get; set; }
                public string TableType { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
