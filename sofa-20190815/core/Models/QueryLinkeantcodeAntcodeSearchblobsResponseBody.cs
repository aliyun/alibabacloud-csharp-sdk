// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeSearchblobsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("EmptyPage")]
        [Validation(Required=false)]
        public bool? EmptyPage { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryLinkeantcodeAntcodeSearchblobsResponseBodyList> List { get; set; }
        public class QueryLinkeantcodeAntcodeSearchblobsResponseBodyList : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("HighlightedContent")]
            [Validation(Required=false)]
            public string HighlightedContent { get; set; }

            [NameInMap("IndexedAt")]
            [Validation(Required=false)]
            public string IndexedAt { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("Ref")]
            [Validation(Required=false)]
            public string Ref { get; set; }

        }

    }

}
