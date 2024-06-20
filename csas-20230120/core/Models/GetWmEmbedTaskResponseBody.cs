// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetWmEmbedTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWmEmbedTaskResponseBodyData Data { get; set; }
        public class GetWmEmbedTaskResponseBodyData : TeaModel {
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            [NameInMap("FileUrlExp")]
            [Validation(Required=false)]
            public string FileUrlExp { get; set; }

            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            [NameInMap("OutFileHashMd5")]
            [Validation(Required=false)]
            public string OutFileHashMd5 { get; set; }

            [NameInMap("OutFileSize")]
            [Validation(Required=false)]
            public long? OutFileSize { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
