// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackJobTableMetaResponseBody : TeaModel {
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

        [NameInMap("TableMetaList")]
        [Validation(Required=false)]
        public List<GetDataTrackJobTableMetaResponseBodyTableMetaList> TableMetaList { get; set; }
        public class GetDataTrackJobTableMetaResponseBodyTableMetaList : TeaModel {
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetDataTrackJobTableMetaResponseBodyTableMetaListColumns> Columns { get; set; }
            public class GetDataTrackJobTableMetaResponseBodyTableMetaListColumns : TeaModel {
                [NameInMap("Charset")]
                [Validation(Required=false)]
                public string Charset { get; set; }

                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("ColumnPosition")]
                [Validation(Required=false)]
                public int? ColumnPosition { get; set; }

                [NameInMap("ColumnType")]
                [Validation(Required=false)]
                public string ColumnType { get; set; }

                [NameInMap("Fictive")]
                [Validation(Required=false)]
                public bool? Fictive { get; set; }

            }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

    }

}
