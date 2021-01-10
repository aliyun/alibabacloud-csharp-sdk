// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class ListDetectProcessesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDetectProcessesResponseBodyData Data { get; set; }
        public class ListDetectProcessesResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListDetectProcessesResponseBodyDataItems> Items { get; set; }
            public class ListDetectProcessesResponseBodyDataItems : TeaModel {
                public string Draft { get; set; }
                public string FileUrl { get; set; }
                public string CreatedAt { get; set; }
                public string Md5 { get; set; }
                public string UpdatedAt { get; set; }
                public bool? NewVersion { get; set; }
                public string Name { get; set; }
                public string Content { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
