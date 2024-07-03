// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDocumentResponseBody : TeaModel {
        [NameInMap("ChunkFileUrl")]
        [Validation(Required=false)]
        public string ChunkFileUrl { get; set; }

        [NameInMap("DocsCount")]
        [Validation(Required=false)]
        public int? DocsCount { get; set; }

        [NameInMap("DocumentLoader")]
        [Validation(Required=false)]
        public string DocumentLoader { get; set; }

        [NameInMap("FileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        [NameInMap("FileMd5")]
        [Validation(Required=false)]
        public string FileMd5 { get; set; }

        [NameInMap("FileMtime")]
        [Validation(Required=false)]
        public string FileMtime { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("FileVersion")]
        [Validation(Required=false)]
        public int? FileVersion { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PlainChunkFileUrl")]
        [Validation(Required=false)]
        public string PlainChunkFileUrl { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TextSplitter")]
        [Validation(Required=false)]
        public string TextSplitter { get; set; }

    }

}
