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
                public string Position { get; set; }

            }

            [NameInMap("IndexList")]
            [Validation(Required=false)]
            public List<GetMetaTableDetailInfoResponseBodyDetailInfoIndexList> IndexList { get; set; }
            public class GetMetaTableDetailInfoResponseBodyDetailInfoIndexList : TeaModel {
                [NameInMap("IndexColumns")]
                [Validation(Required=false)]
                public List<string> IndexColumns { get; set; }

                [NameInMap("IndexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                [NameInMap("IndexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                [NameInMap("IndexType")]
                [Validation(Required=false)]
                public string IndexType { get; set; }

                [NameInMap("Unique")]
                [Validation(Required=false)]
                public bool? Unique { get; set; }

            }

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
