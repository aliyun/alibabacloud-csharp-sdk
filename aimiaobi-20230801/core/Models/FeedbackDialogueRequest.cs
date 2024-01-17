// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class FeedbackDialogueRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("CustomerResponse")]
        [Validation(Required=false)]
        public string CustomerResponse { get; set; }

        [NameInMap("GoodText")]
        [Validation(Required=false)]
        public string GoodText { get; set; }

        [NameInMap("ModifiedResponse")]
        [Validation(Required=false)]
        public string ModifiedResponse { get; set; }

        [NameInMap("Rating")]
        [Validation(Required=false)]
        public string Rating { get; set; }

        [NameInMap("RatingTags")]
        [Validation(Required=false)]
        public List<string> RatingTags { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
