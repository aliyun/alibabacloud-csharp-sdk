// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableColumnResponseBody : TeaModel {
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public List<GetMetaTableColumnResponseBodyColumnList> ColumnList { get; set; }
        public class GetMetaTableColumnResponseBodyColumnList : TeaModel {
            [NameInMap("AutoIncrement")]
            [Validation(Required=false)]
            public bool? AutoIncrement { get; set; }

            [NameInMap("ColumnId")]
            [Validation(Required=false)]
            public string ColumnId { get; set; }

            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            [NameInMap("ColumnType")]
            [Validation(Required=false)]
            public string ColumnType { get; set; }

            [NameInMap("DataLength")]
            [Validation(Required=false)]
            public long? DataLength { get; set; }

            [NameInMap("DataPrecision")]
            [Validation(Required=false)]
            public int? DataPrecision { get; set; }

            [NameInMap("DataScale")]
            [Validation(Required=false)]
            public int? DataScale { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Nullable")]
            [Validation(Required=false)]
            public bool? Nullable { get; set; }

            [NameInMap("Position")]
            [Validation(Required=false)]
            public int? Position { get; set; }

            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }

        }

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

    }

}
