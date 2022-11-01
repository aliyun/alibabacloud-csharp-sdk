// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DumpMetaListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DumpMetaListResponseBodyData Data { get; set; }
        public class DumpMetaListResponseBodyData : TeaModel {
            [NameInMap("DumpMetaList")]
            [Validation(Required=false)]
            public List<DumpMetaListResponseBodyDataDumpMetaList> DumpMetaList { get; set; }
            public class DumpMetaListResponseBodyDataDumpMetaList : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("MetaUrl")]
                [Validation(Required=false)]
                public string MetaUrl { get; set; }

                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public long? UtcModified { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
