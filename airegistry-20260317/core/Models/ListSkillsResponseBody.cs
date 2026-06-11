// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class ListSkillsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSkillsResponseBodyData Data { get; set; }
        public class ListSkillsResponseBodyData : TeaModel {
            [NameInMap("PageItems")]
            [Validation(Required=false)]
            public List<ListSkillsResponseBodyDataPageItems> PageItems { get; set; }
            public class ListSkillsResponseBodyDataPageItems : TeaModel {
                [NameInMap("BizTags")]
                [Validation(Required=false)]
                public string BizTags { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DownloadCount")]
                [Validation(Required=false)]
                public long? DownloadCount { get; set; }

                [NameInMap("EditingVersion")]
                [Validation(Required=false)]
                public string EditingVersion { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public Dictionary<string, string> Labels { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                [NameInMap("OnlineCnt")]
                [Validation(Required=false)]
                public int? OnlineCnt { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ReviewingVersion")]
                [Validation(Required=false)]
                public string ReviewingVersion { get; set; }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("Writeable")]
                [Validation(Required=false)]
                public bool? Writeable { get; set; }

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
