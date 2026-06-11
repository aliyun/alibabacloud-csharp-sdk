// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class ListPromptsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPromptsResponseBodyData Data { get; set; }
        public class ListPromptsResponseBodyData : TeaModel {
            [NameInMap("PageItems")]
            [Validation(Required=false)]
            public List<ListPromptsResponseBodyDataPageItems> PageItems { get; set; }
            public class ListPromptsResponseBodyDataPageItems : TeaModel {
                [NameInMap("BizTags")]
                [Validation(Required=false)]
                public List<string> BizTags { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EditingVersion")]
                [Validation(Required=false)]
                public string EditingVersion { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                [NameInMap("OnlineCnt")]
                [Validation(Required=false)]
                public int? OnlineCnt { get; set; }

                [NameInMap("PromptKey")]
                [Validation(Required=false)]
                public string PromptKey { get; set; }

                [NameInMap("ReviewingVersion")]
                [Validation(Required=false)]
                public string ReviewingVersion { get; set; }

                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public int? SchemaVersion { get; set; }

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
