// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class ListPromptVersionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPromptVersionsResponseBodyData Data { get; set; }
        public class ListPromptVersionsResponseBodyData : TeaModel {
            [NameInMap("PageItems")]
            [Validation(Required=false)]
            public List<ListPromptVersionsResponseBodyDataPageItems> PageItems { get; set; }
            public class ListPromptVersionsResponseBodyDataPageItems : TeaModel {
                [NameInMap("CommitMsg")]
                [Validation(Required=false)]
                public string CommitMsg { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("PromptKey")]
                [Validation(Required=false)]
                public string PromptKey { get; set; }

                [NameInMap("SrcUser")]
                [Validation(Required=false)]
                public string SrcUser { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PagesAvailable")]
            [Validation(Required=false)]
            public int? PagesAvailable { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
