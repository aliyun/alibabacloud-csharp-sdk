// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class GetPromptRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("PromptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

        [NameInMap("Vars")]
        [Validation(Required=false)]
        public string Vars { get; set; }

    }

}
