// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetLogicDatabaseResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LogicDatabase")]
        [Validation(Required=false)]
        public GetLogicDatabaseResponseBodyLogicDatabase LogicDatabase { get; set; }
        public class GetLogicDatabaseResponseBodyLogicDatabase : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            [NameInMap("DatabaseIds")]
            [Validation(Required=false)]
            public GetLogicDatabaseResponseBodyLogicDatabaseDatabaseIds DatabaseIds { get; set; }
            public class GetLogicDatabaseResponseBodyLogicDatabaseDatabaseIds : TeaModel {
                [NameInMap("DatabaseIds")]
                [Validation(Required=false)]
                public List<long?> DatabaseIds { get; set; }

            }

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
            public GetLogicDatabaseResponseBodyLogicDatabaseOwnerIdList OwnerIdList { get; set; }
            public class GetLogicDatabaseResponseBodyLogicDatabaseOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetLogicDatabaseResponseBodyLogicDatabaseOwnerNameList OwnerNameList { get; set; }
            public class GetLogicDatabaseResponseBodyLogicDatabaseOwnerNameList : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
