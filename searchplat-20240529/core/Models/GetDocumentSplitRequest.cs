// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetDocumentSplitRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("document")]
        [Validation(Required=false)]
        public GetDocumentSplitRequestDocument Document { get; set; }
        public class GetDocumentSplitRequestDocument : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("content_encoding")]
            [Validation(Required=false)]
            public string ContentEncoding { get; set; }

            [NameInMap("content_type")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

        }

        [NameInMap("strategy")]
        [Validation(Required=false)]
        public GetDocumentSplitRequestStrategy Strategy { get; set; }
        public class GetDocumentSplitRequestStrategy : TeaModel {
            [NameInMap("compute_type")]
            [Validation(Required=false)]
            public string ComputeType { get; set; }

            [NameInMap("max_chunk_size")]
            [Validation(Required=false)]
            public long? MaxChunkSize { get; set; }

            [NameInMap("need_sentence")]
            [Validation(Required=false)]
            public bool? NeedSentence { get; set; }

        }

    }

}
