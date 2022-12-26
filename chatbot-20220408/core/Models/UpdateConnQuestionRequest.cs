// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateConnQuestionRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("ConnQuestionId")]
        [Validation(Required=false)]
        public long? ConnQuestionId { get; set; }

        [NameInMap("OutlineId")]
        [Validation(Required=false)]
        public long? OutlineId { get; set; }

    }

}
