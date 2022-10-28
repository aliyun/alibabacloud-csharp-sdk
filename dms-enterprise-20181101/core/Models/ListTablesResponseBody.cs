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
                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("NumRows")]
                [Validation(Required=false)]
                public long? NumRows { get; set; }

                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListTablesResponseBodyTableListTableOwnerIdList OwnerIdList { get; set; }
                public class ListTablesResponseBodyTableListTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListTablesResponseBodyTableListTableOwnerNameList OwnerNameList { get; set; }
                public class ListTablesResponseBodyTableListTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                [NameInMap("StoreCapacity")]
                [Validation(Required=false)]
                public long? StoreCapacity { get; set; }

                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TableSchemaName")]
                [Validation(Required=false)]
                public string TableSchemaName { get; set; }

                [NameInMap("TableType")]
                [Validation(Required=false)]
                public string TableType { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
