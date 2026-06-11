// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetNamespaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNamespaceResponseBodyData Data { get; set; }
        public class GetNamespaceResponseBodyData : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("PromptCount")]
            [Validation(Required=false)]
            public int? PromptCount { get; set; }

            [NameInMap("ScanPolicy")]
            [Validation(Required=false)]
            public string ScanPolicy { get; set; }

            [NameInMap("SkillCount")]
            [Validation(Required=false)]
            public int? SkillCount { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceIndex")]
            [Validation(Required=false)]
            public int? SourceIndex { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
