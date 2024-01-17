// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateImageTaskRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("ArticleTaskId")]
        [Validation(Required=false)]
        public string ArticleTaskId { get; set; }

        [NameInMap("ParagraphList")]
        [Validation(Required=false)]
        public List<GenerateImageTaskRequestParagraphList> ParagraphList { get; set; }
        public class GenerateImageTaskRequestParagraphList : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

    }

}
