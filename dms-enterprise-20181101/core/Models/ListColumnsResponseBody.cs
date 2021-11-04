// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListColumnsResponseBody : TeaModel {
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public ListColumnsResponseBodyColumnList ColumnList { get; set; }
        public class ListColumnsResponseBodyColumnList : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public List<ListColumnsResponseBodyColumnListColumn> Column { get; set; }
            public class ListColumnsResponseBodyColumnListColumn : TeaModel {
                public bool? AutoIncrement { get; set; }
                public string ColumnId { get; set; }
                public string ColumnName { get; set; }
                public string ColumnType { get; set; }
                public long? DataLength { get; set; }
                public int? DataPrecision { get; set; }
                public int? DataScale { get; set; }
                public string DefaultValue { get; set; }
                public string Description { get; set; }
                public string FunctionType { get; set; }
                public bool? Nullable { get; set; }
                public string SecurityLevel { get; set; }
                public bool? Sensitive { get; set; }
            }
        };

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
