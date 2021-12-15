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
                public string Code { get; set; }
                public long? Id { get; set; }
                public string MetaUrl { get; set; }
                public string Msg { get; set; }
                public string Status { get; set; }
                public string UtcCreate { get; set; }
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
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
