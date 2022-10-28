// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLogicDatabasesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LogicDatabaseList")]
        [Validation(Required=false)]
        public ListLogicDatabasesResponseBodyLogicDatabaseList LogicDatabaseList { get; set; }
        public class ListLogicDatabasesResponseBodyLogicDatabaseList : TeaModel {
            [NameInMap("LogicDatabase")]
            [Validation(Required=false)]
            public List<ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabase> LogicDatabase { get; set; }
            public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabase : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerIdList OwnerIdList { get; set; }
                public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerNameList OwnerNameList { get; set; }
                public class ListLogicDatabasesResponseBodyLogicDatabaseListLogicDatabaseOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

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
