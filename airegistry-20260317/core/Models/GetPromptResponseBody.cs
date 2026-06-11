// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetPromptResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPromptResponseBodyData Data { get; set; }
        public class GetPromptResponseBodyData : TeaModel {
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

            [NameInMap("VersionDetails")]
            [Validation(Required=false)]
            public List<GetPromptResponseBodyDataVersionDetails> VersionDetails { get; set; }
            public class GetPromptResponseBodyDataVersionDetails : TeaModel {
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

            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
