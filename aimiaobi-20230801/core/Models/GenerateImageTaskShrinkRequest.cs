// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateImageTaskShrinkRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("ArticleTaskId")]
        [Validation(Required=false)]
        public string ArticleTaskId { get; set; }

        [NameInMap("ParagraphList")]
        [Validation(Required=false)]
        public string ParagraphListShrink { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

    }

}
