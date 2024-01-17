// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class FetchImageTaskShrinkRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("ArticleTaskId")]
        [Validation(Required=false)]
        public string ArticleTaskId { get; set; }

        [NameInMap("TaskIdList")]
        [Validation(Required=false)]
        public string TaskIdListShrink { get; set; }

    }

}
