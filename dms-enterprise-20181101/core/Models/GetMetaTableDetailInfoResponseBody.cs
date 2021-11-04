// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableDetailInfoResponseBody : TeaModel {
        [NameInMap("DetailInfo")]
        [Validation(Required=false)]
        public GetMetaTableDetailInfoResponseBodyDetailInfo DetailInfo { get; set; }
        public class GetMetaTableDetailInfoResponseBodyDetailInfo : TeaModel {
            [NameInMap("ColumnList")]
            [Validation(Required=false)]
            public List<GetMetaTableDetailInfoResponseBodyDetailInfoColumnList> ColumnList { get; set; }
            public class GetMetaTableDetailInfoResponseBodyDetailInfoColumnList : TeaModel {
                public bool? AutoIncrement { get; set; }
                public string ColumnId { get; set; }
                public string ColumnName { get; set; }
                public string ColumnType { get; set; }
                public long? DataLength { get; set; }
                public int? DataPrecision { get; set; }
                public int? DataScale { get; set; }
                public string Description { get; set; }
                public bool? Nullable { get; set; }
                public string Position { get; set; }
            }
            [NameInMap("IndexList")]
            [Validation(Required=false)]
            public List<GetMetaTableDetailInfoResponseBodyDetailInfoIndexList> IndexList { get; set; }
            public class GetMetaTableDetailInfoResponseBodyDetailInfoIndexList : TeaModel {
                public List<string> IndexColumns { get; set; }
                public string IndexId { get; set; }
                public string IndexName { get; set; }
                public string IndexType { get; set; }
                public bool? Unique { get; set; }
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
