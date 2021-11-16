// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableColumnResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTableColumnResponseBodyData Data { get; set; }
        public class GetMetaTableColumnResponseBodyData : TeaModel {
            [NameInMap("ColumnList")]
            [Validation(Required=false)]
            public List<GetMetaTableColumnResponseBodyDataColumnList> ColumnList { get; set; }
            public class GetMetaTableColumnResponseBodyDataColumnList : TeaModel {
                public string Caption { get; set; }
                public string ColumnGuid { get; set; }
                public string ColumnName { get; set; }
                public string ColumnType { get; set; }
                public string Comment { get; set; }
                public bool? IsForeignKey { get; set; }
                public bool? IsPartitionColumn { get; set; }
                public bool? IsPrimaryKey { get; set; }
                public int? Position { get; set; }
            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
