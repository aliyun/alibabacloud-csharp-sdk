// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetSkillDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillDetailResponseBodyData Data { get; set; }
        public class GetSkillDetailResponseBodyData : TeaModel {
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

            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<GetSkillDetailResponseBodyDataVersions> Versions { get; set; }
            public class GetSkillDetailResponseBodyDataVersions : TeaModel {
                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                [NameInMap("CommitMsg")]
                [Validation(Required=false)]
                public string CommitMsg { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DownloadCount")]
                [Validation(Required=false)]
                public long? DownloadCount { get; set; }

                [NameInMap("PublishPipelineInfo")]
                [Validation(Required=false)]
                public string PublishPipelineInfo { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("Writeable")]
            [Validation(Required=false)]
            public bool? Writeable { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
